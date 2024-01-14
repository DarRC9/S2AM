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
  final _fullNameController = TextEditingController();
  final _websiteController = TextEditingController();
  final _mangasStream = supabase.from('mangas').stream(primaryKey: ['id']).eq(
      'profiles_id', supabase.auth.currentUser!.id);

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
      _fullNameController.text = (data['full_name'] ?? '') as String;
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
    final fullName = _fullNameController.text.trim();
    final website = _websiteController.text.trim();
    final user = supabase.auth.currentUser;
    final updates = {
      'id': user!.id,
      'username': userName,
      'full_name': fullName,
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
              Container(
                  padding: const EdgeInsets.all(15),
                  decoration: BoxDecoration(
                    border: Border.all(
                      color: Colors.white,
                      width: 2,
                    ),
                    borderRadius: BorderRadius.circular(20),
                  ),
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      TextFormField(
                        controller: _usernameController,
                        decoration:
                            const InputDecoration(labelText: 'Username'),
                        style: const TextStyle(color: Colors.white),
                      ),
                      const SizedBox(height: 18),
                      TextFormField(
                        controller: _fullNameController,
                        decoration:
                            const InputDecoration(labelText: 'Full Name'),
                        style: const TextStyle(color: Colors.white),
                      ),
                      const SizedBox(height: 18),
                      TextFormField(
                        controller: _websiteController,
                        decoration:
                            const InputDecoration(labelText: 'Biography'),
                        style: const TextStyle(color: Colors.white),
                      ),
                      const SizedBox(height: 18),
                      Row(
                        mainAxisAlignment: MainAxisAlignment
                            .spaceEvenly, // Adjust alignment as needed
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
                  )),
            ],
          );
  }

  Widget _buildMangasTab() {
    TextEditingController searchController = TextEditingController();
    bool showLoading = false;

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
                        TextEditingController titleController =
                            TextEditingController();
                        TextEditingController authorController =
                            TextEditingController();
                        TextEditingController chaptersController =
                            TextEditingController();

                        return SimpleDialog(
                          title: const Text(
                            'Add manga to your list',
                            style: TextStyle(color: Colors.white),
                          ),
                          contentPadding: const EdgeInsets.only(
                              left: 30, right: 30, top: 20, bottom: 2),
                          children: [
                            TextFormField(
                              controller: titleController,
                              style: const TextStyle(color: Colors.white),
                              decoration: InputDecoration(labelText: 'Title'),
                            ),
                            TextFormField(
                              controller: authorController,
                              style: const TextStyle(color: Colors.white),
                              decoration: InputDecoration(labelText: 'Author'),
                            ),
                            TextFormField(
                              controller: chaptersController,
                              style: const TextStyle(color: Colors.white),
                              decoration:
                                  InputDecoration(labelText: 'Chapters'),
                            ),
                            SizedBox(height: 10),
                            ElevatedButton(
                              onPressed: () async {
                                String title = titleController.text;
                                String author = authorController.text;
                                String chapters = chaptersController.text;

                                await supabase.from('mangas').insert([
                                  {
                                    'title': title,
                                    'author': author,
                                    'chapters': chapters,
                                    'profiles_id':
                                        supabase.auth.currentUser!.id,
                                  }
                                ]);

                                Navigator.of(context).pop();
                              },
                              child: Text('Add'),
                            ),
                          ],
                        );
                      },
                    );
                  },
                ),
                Spacer(),
                IconButton(
                  icon: const Icon(Icons.search),
                  onPressed: () {
                    showDialog(
                      context: context,
                      builder: (context) {
                        return AlertDialog(
                          title: const Text('Search Manga'),
                          content: TextField(
                            style: const TextStyle(color: Colors.white),
                            controller: searchController,
                            onChanged: (value) {
                              setState(() {
                                // searchValue = value;
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
                const SizedBox(width: 15),
              ],
            ),
          ),
        ),
        StreamBuilder<List<Map<String, dynamic>>>(
          stream: _mangasStream,
          builder: (context, snapshot) {
            if (showLoading) {
              Future.delayed(Duration(seconds: 5), () {
                setState(() {
                  showLoading = false;
                });
              });
              return const Center(child: CircularProgressIndicator());
            }

            if (!snapshot.hasData || snapshot.data!.isEmpty) {
              return const Center(
                child: Text(
                    "You don't have any manga in your list, try to add one!"),
              );
            }

            final mangas = snapshot.data!;

            return Expanded(
              child: ListView.builder(
                itemCount: mangas.length,
                itemBuilder: (context, index) {
                  final manga = mangas[index];

                  Widget coverWidget = Container(
                    height: 400,
                    color: Colors.grey, // Gray background color
                  );

                  if (manga['cover_img'] != null && manga['cover_img'] != '') {
                    coverWidget = Image.network(
                      manga['cover_img'] as String,
                      height: 400,
                      fit: BoxFit.cover,
                    );
                  }

                  return ListTile(
                    title: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(manga['title'] as String,
                            style: TextStyle(
                                fontSize: 20, fontWeight: FontWeight.bold)),
                        Text('Author: ${manga['author']}',
                            style: TextStyle(fontSize: 16)),
                        Text('Chapters: ${manga['chapters']}',
                            style: TextStyle(fontSize: 16)),
                      ],
                    ),
                    leading: coverWidget,
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
        )
      ],
    );
  }

  // Future<List<String>> _searchMangas(String title) async {
  //   final results = await supabase
  //       .from('mangas')
  //       .select('title')
  //       .textSearch('fts', "$title:*");

  //   if (results. != null) {
  //     throw results.error!;
  //   }
  //   return results.data as List<String>;
  // }
}
