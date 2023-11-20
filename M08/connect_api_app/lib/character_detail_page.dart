// character_detail_page.dart
import 'package:flutter/material.dart';

class CharacterDetailPage extends StatelessWidget {
  final Map<String, dynamic> characterData;
  final String characterImageUrl;

  const CharacterDetailPage({
    Key? key,
    required this.characterData,
    required this.characterImageUrl,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(characterData['name']),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            // Left part with the image
            Expanded(
              flex: 1,
              child: Image.network(
                characterImageUrl,
                height: double.infinity, // Takes full height
                width: double.infinity, // Takes one-third width
                fit: BoxFit.cover,
              ),
            ),
            const SizedBox(width: 16), // Add spacing between image and text
            // Right part with information
            Expanded(
              flex: 2,
              child: Container(
                color: const Color.fromARGB(
                    255, 49, 49, 49), // Light gray background color
                padding: const EdgeInsets.all(16),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Container(
                        padding: const EdgeInsets.all(8),
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color: Colors.grey[600],
                        ),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(
                              "${characterData['name']}",
                              style: const TextStyle(
                                fontSize: 30,
                                fontWeight: FontWeight.bold,
                                color: Colors.white,
                              ),
                            ),
                            Text(
                              "${characterData['title']}",
                              style: const TextStyle(
                                  fontSize: 25,
                                  fontWeight: FontWeight.bold,
                                  color: Colors.white),
                            ),
                            Text(
                              "${characterData['vision']}",
                              style: const TextStyle(
                                fontSize: 16,
                                fontWeight: FontWeight.bold,
                                color: Colors.white,
                              ),
                            ),
                            Text(
                              "${characterData['nation']}",
                              style: const TextStyle(
                                fontSize: 16,
                                fontWeight: FontWeight.bold,
                                color: Colors.white,
                              ),
                            ),
                            const SizedBox(height: 16),
                            Text(
                              "Affiliation: ${characterData['affiliation']}",
                              style: const TextStyle(
                                  fontSize: 16, color: Colors.white),
                            ),
                            Text(
                              "Rarity: ${characterData['rarity']}",
                              style: const TextStyle(
                                  fontSize: 16, color: Colors.white),
                            ),
                            Text(
                              "Release Date: ${characterData['release']}",
                              style: const TextStyle(
                                  fontSize: 16, color: Colors.white),
                            ),
                            Text(
                              "Constellation: ${characterData['constellation']}",
                              style: const TextStyle(
                                  fontSize: 16, color: Colors.white),
                            ),
                            Text(
                              "Birthday: ${characterData['birthday']}",
                              style: const TextStyle(
                                  fontSize: 16, color: Colors.white),
                            ),
                            const SizedBox(height: 16),
                            Text(
                              "Description: ${characterData['description']}",
                              style: const TextStyle(
                                  fontSize: 16, color: Colors.white),
                            ),
                          ],
                        )),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
