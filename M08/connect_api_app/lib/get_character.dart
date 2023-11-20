import 'dart:convert';
import 'package:http/http.dart' as http;

class Character {
  static const String baseUrl = "https://genshin.jmp.blue/characters/";

  Future<Map<String, dynamic>> fetchCharacterData(String characterName) async {
    final String apiUrl = "$baseUrl$characterName";

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
        throw Exception(
            "Failed to fetch character data: ${response.statusCode}");
      }
    } catch (e) {
      throw Exception("Error during character data request: $e");
    }
  }

  Future<String> fetchCharacterImageUrl(String characterName) async {
    final String imageUrl = "$baseUrl$characterName/card";

    try {
      final response = await http.get(Uri.parse(imageUrl));

      if (response.statusCode == 200) {
        return imageUrl;
      } else {
        throw Exception(
            "Failed to fetch character image: ${response.statusCode}");
      }
    } catch (e) {
      throw Exception("Error during character image request: $e");
    }
  }
}
