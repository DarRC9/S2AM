import 'package:flutter/material.dart';
import 'get_character.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: MyHomePage(),
      theme: ThemeData(
        scaffoldBackgroundColor: Colors.grey[900],
        appBarTheme: const AppBarTheme(
          color: Colors.teal,
        ),
      ),
    );
  }
}

class MyHomePage extends StatefulWidget {
  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  List<Map<String, dynamic>> characterList = [];
  bool isLoading = true;
  String error = '';

  Map<String, Color> visionColorMap = {
    'Electro': Colors.purple,
    'Anemo': Colors.greenAccent,
    'Pyro': Colors.deepOrange,
    'Cryo': Colors.lightBlue,
    'Hydro': Colors.blue,
    'Geo': Colors.brown,
    'Dendro': Colors.green,
  };

  @override
  void initState() {
    super.initState();
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
        title: const Text("Genshin Impact API Example"),
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
                      final vision = characterData['vision'];

                      return Card(
                        margin: const EdgeInsets.all(10),
                        color: Colors.grey[800],
                        child: Padding(
                          padding: const EdgeInsets.all(8.0),
                          child: Row(
                            children: [
                              ClipRRect(
                                borderRadius: BorderRadius.circular(15),
                                child: Image.network(
                                  characterImageUrl,
                                  height: 100,
                                  width: 100,
                                  fit: BoxFit.cover,
                                ),
                              ),
                              const SizedBox(width: 10),
                              Expanded(
                                child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Text(
                                      "${characterData['name']}",
                                      style: TextStyle(
                                        color: visionColorMap[vision],
                                        fontWeight: FontWeight.bold,
                                      ),
                                    ),
                                    Text("Vision: $vision",
                                        style: TextStyle(
                                            color: visionColorMap[vision])),
                                    Text("Nation: ${characterData['nation']}",
                                        style: const TextStyle(
                                            color: Colors.white)),
                                  ],
                                ),
                              ),
                            ],
                          ),
                        ),
                      );
                    },
                  ),
      ),
    );
  }
}
