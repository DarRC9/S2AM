import 'package:flutter/material.dart';
import 'dart:async';
import 'character_model.dart';
import 'character_list.dart';
import 'new_character_form.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'My fav Characters',
      theme: ThemeData(brightness: Brightness.dark),
      home: const MyHomePage(
        title: 'My fav Characters',
      ),
    );
  }
}

class MyHomePage extends StatefulWidget {
  final String title;
  const MyHomePage({Key? key, required this.title}) : super(key: key);

  @override
  // ignore: library_private_types_in_public_api
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  List<Character> initialCharacters = [
    Character('keqing'),
    Character('Lynette'),
    Character('Yae-miko')
  ];

  Future _showNewCharacterForm() async {
    Character newCharacter = await Navigator.of(context).push(
      MaterialPageRoute(builder: (BuildContext context) {
        return const AddCharacterFormPage();
      }),
    );
    //print(newCharacter);
    initialCharacters.add(newCharacter);
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    var key = GlobalKey<ScaffoldState>();
    return Scaffold(
      key: key,
      appBar: AppBar(
        title: Text(widget.title, style: const TextStyle(color: Colors.white)),
        centerTitle: true,
        backgroundColor: const Color(0xFF0B479E),
        actions: <Widget>[
          IconButton(
            icon: const Icon(Icons.add),
            onPressed: _showNewCharacterForm,
          ),
        ],
      ),
      body: Container(
          color: const Color.fromARGB(255, 88, 111, 137),
          child: Center(
            child: CharacterList(initialCharacters),
          )),
    );
  }
}
