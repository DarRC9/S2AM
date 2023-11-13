import 'package:genshin_api_app/character_model.dart';
import 'package:flutter/material.dart';

class AddCharacterFormPage extends StatefulWidget {
  const AddCharacterFormPage({super.key});

  @override
  // ignore: library_private_types_in_public_api
  _AddCharacterFormPageState createState() => _AddCharacterFormPageState();
}

class _AddCharacterFormPageState extends State<AddCharacterFormPage> {
  TextEditingController nameController = TextEditingController();

  void submitPup(BuildContext context) {
    if (nameController.text.isEmpty) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
        backgroundColor: Colors.redAccent,
        content: Text('You forgot to insert the character name'),
      ));
    } else {
      var newCharacter = Character(nameController.text);
      Navigator.of(context).pop(newCharacter);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Add a new character'),
        backgroundColor: const Color(0xFF0B479E),
      ),
      body: Container(
        color: const Color(0xFFABCAED),
        child: Padding(
          padding: const EdgeInsets.symmetric(vertical: 8.0, horizontal: 32.0),
          child: Column(children: [
            Padding(
              padding: const EdgeInsets.only(bottom: 8.0),
              child: TextField(
                controller: nameController,
                style: const TextStyle(decoration: TextDecoration.none),
                onChanged: (v) => nameController.text = v,
                decoration: const InputDecoration(
                  labelText: 'Character Name',
                  labelStyle: TextStyle(color: Colors.black),
                ),
              ),
            ),
            Padding(
              padding: const EdgeInsets.all(16.0),
              child: Builder(
                builder: (context) {
                  return ElevatedButton(
                    onPressed: () => submitPup(context),
                    child: const Text('Submit Character'),
                  );
                },
              ),
            )
          ]),
        ),
      ),
    );
  }
}
