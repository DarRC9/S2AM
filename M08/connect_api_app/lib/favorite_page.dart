import 'package:flutter/material.dart';
import 'character_card.dart';

class FavoritePage extends StatelessWidget {
  final List<Map<String, dynamic>> characterList;
  final Map<String, Color> visionColorMap;

  const FavoritePage(this.characterList, this.visionColorMap, {Key? key})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    final favoriteCharacters = characterList
        .where((character) => character['favorite'] == true)
        .toList();

    return Scaffold(
      appBar: AppBar(
        title: const Text("Favorite Characters"),
      ),
      body: ListView.builder(
        itemCount: favoriteCharacters.length,
        itemBuilder: (context, index) {
          final characterData = favoriteCharacters[index]['data'];
          final characterImageUrl = favoriteCharacters[index]['image'];

          return CharacterCard(
            characterData: characterData,
            characterImageUrl: characterImageUrl,
            visionColorMap: visionColorMap,
          );
        },
      ),
    );
  }
}
