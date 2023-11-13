// api_service.dart
import 'dart:convert';
import 'package:http/http.dart' as http;

class Character {
  Future<Map<String, dynamic>> fetchCharacterData(String characterName) async {
    final String apiUrl = "https://genshin.jmp.blue/characters/$characterName";

    try {
      final response = await http.get(Uri.parse(apiUrl));

      if (response.statusCode == 200) {
        Map<String, dynamic> responseData = json.decode(response.body);
        return {
          'vision': responseData['vision'],
          'nation': responseData['nation'],
          'name': responseData['name'],
        };
      } else {
        throw Exception("Error: ${response.statusCode}");
      }
    } catch (e) {
      throw Exception("Error: $e");
    }
  }

  Future<String> fetchCharacterImageUrl(String characterName) async {
    final String imageUrl =
        "https://genshin.jmp.blue/characters/$characterName/card";

    try {
      final response = await http.get(Uri.parse(imageUrl));

      if (response.statusCode == 200) {
        return imageUrl;
      } else {
        throw Exception("Error fetching image: ${response.statusCode}");
      }
    } catch (e) {
      throw Exception("Error fetching image: $e");
    }
  }
}
