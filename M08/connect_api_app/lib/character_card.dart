import 'package:flutter/material.dart';

class CharacterCard extends StatelessWidget {
  final Map<String, dynamic> characterData;
  final String characterImageUrl;
  final Map<String, Color> visionColorMap;
  final bool isFavorite;

  const CharacterCard({
    Key? key,
    required this.characterData,
    required this.characterImageUrl,
    required this.visionColorMap,
    this.isFavorite = false,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
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
                height: 200,
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
                      style: TextStyle(color: visionColorMap[vision])),
                  Text("Nation: ${characterData['nation']}",
                      style: const TextStyle(color: Colors.white)),
                ],
              ),
            ),
            const Spacer(), // Add this Spacer to push the heart icon to the right

            isFavorite
                ? const Icon(
                    Icons.favorite,
                    color: Colors.red,
                  )
                : const SizedBox(),
          ],
        ),
      ),
    );
  }
}
