//**DIFF */

import 'package:flutter/material.dart';
import 'package:supabase_flutter/supabase_flutter.dart';
import 'package:supabase_manga_app/components/avatar.dart';
import 'package:supabase_manga_app/main.dart';

class AccountPage extends StatefulWidget {
  const AccountPage({super.key});

  @override
  _AccountPageState createState() => _AccountPageState();
}

class _AccountPageState extends State<AccountPage> {
  final _usernameController = TextEditingController();
  final _websiteController = TextEditingController();
  final _mangasStream = supabase.from('mangas').stream(primaryKey: ['id']);

  String? _avatarUrl;
  var _loading = true;

  /// Called once a user id is received within `onAuthenticated()`
  Future<void> _getProfile() async {
    setState(() {
      _loading = true;
    });

    try {
      final userId = supabase.auth.currentSession!.user.id;
      final data =
          await supabase.from('profiles').select().eq('id', userId).single();
      _usernameController.text = (data['username'] ?? '') as String;
      _websiteController.text = (data['website'] ?? '') as String;
      _avatarUrl = (data['avatar_url'] ?? '') as String;
    } on PostgrestException catch (error) {
      SnackBar(
        content: Text(error.message),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } catch (error) {
      SnackBar(
        content: const Text('Unexpected error occurred'),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } finally {
      if (mounted) {
        setState(() {
          _loading = false;
        });
      }
    }
  }

  Future<void> _updateProfile() async {
    setState(() {
      _loading = true;
    });
    final userName = _usernameController.text.trim();
    final website = _websiteController.text.trim();
    final user = supabase.auth.currentUser;
    final updates = {
      'id': user!.id,
      'username': userName,
      'website': website,
      'updated_at': DateTime.now().toIso8601String(),
    };
    try {
      await supabase.from('profiles').upsert(updates);
      if (mounted) {
        const SnackBar(
          content: Text('Successfully updated profile!'),
        );
      }
    } on PostgrestException catch (error) {
      SnackBar(
        content: Text(error.message),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } catch (error) {
      SnackBar(
        content: const Text('Unexpected error occurred'),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } finally {
      if (mounted) {
        setState(() {
          _loading = false;
        });
      }
    }
  }

  Future<void> _signOut() async {
    try {
      await supabase.auth.signOut();
    } on AuthException catch (error) {
      SnackBar(
        content: Text(error.message),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } catch (error) {
      SnackBar(
        content: const Text('Unexpected error occurred'),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } finally {
      if (mounted) {
        Navigator.of(context).pushReplacementNamed('/login');
      }
    }
  }

  Future<void> _onUpload(String imageUrl) async {
    try {
      final userId = supabase.auth.currentUser!.id;
      await supabase.from('profiles').upsert({
        'id': userId,
        'avatar_url': imageUrl,
      });
      if (mounted) {
        const SnackBar(
          content: Text('Updated your profile image!'),
        );
      }
    } on PostgrestException catch (error) {
      SnackBar(
        content: Text(error.message),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    } catch (error) {
      SnackBar(
        content: const Text('Unexpected error occurred'),
        backgroundColor: Theme.of(context).colorScheme.error,
      );
    }
    if (!mounted) {
      return;
    }

    setState(() {
      _avatarUrl = imageUrl;
    });
  }

  @override
  void initState() {
    super.initState();
    _getProfile();
  }

  @override
  void dispose() {
    _usernameController.dispose();
    _websiteController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
      length: 2, // Number of tabs
      child: Scaffold(
        appBar: AppBar(
          title: const Text('Profile'),
        ),
        body: Column(
          children: [
            Expanded(
              child: TabBarView(
                children: [
                  // Tab 1: User Info
                  _buildUserInfoTab(),
                  // Tab 2: Mangas
                  _buildMangasTab(),
                ],
              ),
            ),
            const SizedBox(height: 18), // Add some spacing if needed
            TabBar(
              tabs: [
                Tab(
                  icon: Icon(Icons.person),
                  text: 'User Info',
                ),
                Tab(
                  icon: Icon(Icons.book),
                  text: 'Mangas',
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildUserInfoTab() {
    return _loading
        ? const Center(child: CircularProgressIndicator())
        : ListView(
            padding: const EdgeInsets.symmetric(vertical: 18, horizontal: 12),
            children: [
              Avatar(
                imageUrl: _avatarUrl,
                onUpload: _onUpload,
              ),
              const SizedBox(height: 18),
              TextFormField(
                controller: _usernameController,
                decoration: const InputDecoration(labelText: 'Username'),
              ),
              const SizedBox(height: 18),
              TextFormField(
                controller: _websiteController,
                decoration: const InputDecoration(labelText: 'Biography'),
              ),
              const SizedBox(height: 18),
              Row(
                mainAxisAlignment:
                    MainAxisAlignment.spaceEvenly, // Adjust alignment as needed
                children: [
                  ElevatedButton(
                    onPressed: _loading ? null : _updateProfile,
                    child: Text(_loading ? 'Saving...' : 'Update'),
                  ),
                  TextButton(
                    onPressed: _signOut,
                    child: const Text('Sign Out'),
                  ),
                ],
              ),
            ],
          );
  }

  Widget _buildMangasTab() {
    TextEditingController searchController = TextEditingController();
    String searchValue = '';

    return Column(
      children: [
        Align(
          alignment: Alignment.topLeft,
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Row(
              children: [
                IconButton(
                  icon: const Icon(Icons.add),
                  onPressed: () {
                    showDialog(
                      context: context,
                      builder: (context) {
                        return SimpleDialog(
                          title: const Text('Add manga to your list'),
                          contentPadding: const EdgeInsets.only(
                              left: 30, right: 30, top: 20, bottom: 2),
                          children: [
                            TextFormField(onFieldSubmitted: (value) async {
                              await supabase.from('mangas').insert([
                                {
                                  'title': value,
                                  'profiles_id': supabase.auth.currentUser!.id,
                                }
                              ]);

                              Navigator.of(context).pop();
                            })
                          ],
                        );
                      },
                    );
                  },
                ),
                const SizedBox(width: 220),
                // Add spacing between buttons
                IconButton(
                  icon: const Icon(Icons.search),
                  onPressed: () {
                    showDialog(
                      context: context,
                      builder: (context) {
                        return AlertDialog(
                          title: const Text('Search Manga'),
                          content: TextField(
                            controller: searchController,
                            onChanged: (value) {
                              setState(() {
                                searchValue = value;
                              });
                            },
                          ),
                          actions: [
                            TextButton(
                              onPressed: () {
                                Navigator.pop(context);
                              },
                              child: const Text('Cancel'),
                            ),
                            TextButton(
                              onPressed: () {
                                Navigator.pop(context);
                                // Update the UI with filtered mangas
                                setState(() {});
                              },
                              child: const Text('Search'),
                            ),
                          ],
                        );
                      },
                    );
                  },
                ),
              ],
            ),
          ),
        ),
        StreamBuilder<List<Map<String, dynamic>>>(
          stream: _mangasStream,
          builder: (context, snapshot) {
            if (!snapshot.hasData) {
              return const Center(child: CircularProgressIndicator());
            }
            final mangas = snapshot.data!;

            // Filter mangas based on search criteria
            final filteredMangas = _filterMangas(mangas, searchValue);

            return Expanded(
              child: ListView.builder(
                itemCount: filteredMangas.length,
                itemBuilder: (context, index) {
                  final manga = filteredMangas[index];
                  return ListTile(
                    title: Text(manga['title'] as String),
                    trailing: IconButton(
                      icon: const Icon(Icons.delete),
                      onPressed: () async {
                        await supabase
                            .from('mangas')
                            .delete()
                            .eq('id', manga['id']);
                      },
                    ),
                  );
                },
              ),
            );
          },
        ),
      ],
    );
  }

  List<Map<String, dynamic>> _filterMangas(
      List<Map<String, dynamic>> allMangas, String searchValue) {
    // Filter mangas based on search criteria
    return allMangas
        .where((manga) => (manga['title'] as String)
            .toLowerCase()
            .contains(searchValue.toLowerCase()))
        .toList();
  }
}
