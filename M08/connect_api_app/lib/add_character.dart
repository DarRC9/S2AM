// add_character.dart
import 'package:flutter/material.dart';
import 'get_character.dart';

class AddCharacter {
  final BuildContext context;

  AddCharacter(this.context);

  Future<void> addCharacter(String characterName,
      List<Map<String, dynamic>> characterList, Function setState) async {
    try {
      final Character character = Character();
      final characterData = await character.fetchCharacterData(characterName);
      final characterImageUrl =
          await character.fetchCharacterImageUrl(characterName);

      setState(() {
        characterList.add({
          'data': characterData,
          'image': characterImageUrl,
        });
      });
    } catch (e) {
      // ignore: use_build_context_synchronously
      showErrorDialog(context, "Character not found");
    }
  }

  Future<void> showErrorDialog(
      BuildContext context, String errorMessage) async {
    return showDialog<void>(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Error'),
          content: Text(errorMessage),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop(); // Close the dialog
              },
              child: const Text('OK'),
            ),
          ],
        );
      },
    );
  }

  Future<void> showAddCharacterDialog(
      TextEditingController newCharacterController,
      Function addCharacter,
      List<Map<String, dynamic>> characterList,
      Function setState) async {
    return showDialog<void>(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Add Character'),
          content: Column(
            children: [
              TextField(
                controller: newCharacterController,
                decoration: const InputDecoration(labelText: 'Character Name'),
              ),
              const SizedBox(height: 16),
              ElevatedButton(
                onPressed: () {
                  Navigator.of(context).pop(); // Close the dialog
                  addCharacter(
                      newCharacterController.text, characterList, setState);
                  newCharacterController.clear();
                },
                child: const Text('Add'),
              ),
            ],
          ),
        );
      },
    );
  }
}
