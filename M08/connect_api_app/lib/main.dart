import 'package:flutter/material.dart';
import 'get_character.dart';
import 'character_card.dart';
import 'add_character.dart';
import 'favorite_page.dart';
import 'character_detail_page.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: const MyHomePage(),
      theme: ThemeData(
        scaffoldBackgroundColor: Colors.grey[900],
        appBarTheme: const AppBarTheme(
          color: Color.fromARGB(255, 56, 56, 56),
        ),
      ),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  List<Map<String, dynamic>> characterList = [];
  bool isLoading = true;
  String error = '';
  TextEditingController newCharacterController = TextEditingController();

  Map<String, Color> visionColorMap = {
    'Electro': Colors.purple,
    'Anemo': Colors.greenAccent,
    'Pyro': Colors.deepOrange,
    'Cryo': Colors.lightBlue,
    'Hydro': Colors.blue,
    'Geo': Colors.brown,
    'Dendro': Colors.green,
  };

  late AddCharacter addCharacter; // Declare an instance of AddCharacter

  @override
  void initState() {
    super.initState();
    addCharacter = AddCharacter(context); // Initialize the instance
    fetchCharacterData();
  }

  void fetchCharacterData() async {
    try {
      final Character character = Character();

      List<String> characterNames = [
        'keqing',
        'ganyu',
        'kazuha',
        'zhongli',
        'yoimiya',
        'mona',
        'alhaitham'
      ];

      for (var characterName in characterNames) {
        final characterData = await character.fetchCharacterData(characterName);
        final characterImageUrl =
            await character.fetchCharacterImageUrl(characterName);
        setState(() {
          characterList.add({
            'data': characterData,
            'image': characterImageUrl,
            'favorite': false,
          });
        });
      }

      setState(() {
        isLoading = false;
      });
    } catch (e) {
      setState(() {
        error = "$e";
        isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Genshin Impact API"),
        actions: [
          Padding(
            padding: const EdgeInsets.only(right: 20.0),
            child: IconButton(
              icon: const Icon(Icons.add, color: Colors.white),
              onPressed: () => addCharacter.showAddCharacterDialog(
                  newCharacterController,
                  addCharacter.addCharacter,
                  characterList,
                  setState),
            ),
          ),
          IconButton(
            icon: const Icon(Icons.favorite, color: Colors.white),
            onPressed: () {
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) =>
                      FavoritePage(characterList, visionColorMap),
                ),
              );
            },
          ),
        ],
      ),
      body: Center(
        child: isLoading
            ? const CircularProgressIndicator()
            : error.isNotEmpty
                ? Text(error)
                : ListView.builder(
                    itemCount: characterList.length,
                    itemBuilder: (context, index) {
                      final characterData = characterList[index]['data'];
                      final characterImageUrl = characterList[index]['image'];

                      return GestureDetector(
                        onTap: () {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (context) => CharacterDetailPage(
                                characterData: characterData,
                                characterImageUrl: characterImageUrl,
                              ),
                            ),
                          );
                        },
                        child: Dismissible(
                          key: Key(characterData['name']),
                          onDismissed: (direction) {
                            if (direction == DismissDirection.startToEnd) {
                              setState(() {
                                characterList[index]['favorite'] = true;
                              });
                            } else if (direction ==
                                DismissDirection.endToStart) {
                              Future.delayed(
                                  const Duration(milliseconds: 10000), () {
                                setState(() {
                                  characterList.removeAt(index);
                                });
                              });
                            }
                          },
                          background: Container(
                            color: const Color.fromARGB(255, 51, 116, 53),
                            alignment: Alignment.centerLeft,
                            padding: const EdgeInsets.all(16),
                            child: const Icon(
                              Icons.favorite,
                              color: Colors.white,
                            ),
                          ),
                          secondaryBackground: Container(
                            color: const Color.fromARGB(255, 177, 47, 38),
                            alignment: Alignment.centerRight,
                            padding: const EdgeInsets.all(16),
                            child: const Icon(
                              Icons.delete,
                              color: Colors.white,
                            ),
                          ),
                          child: CharacterCard(
                            characterData: characterData,
                            characterImageUrl: characterImageUrl,
                            visionColorMap: visionColorMap,
                          ),
                        ),
                      );
                    },
                  ),
      ),
    );
  }
}
