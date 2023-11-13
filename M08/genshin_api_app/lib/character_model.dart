// import 'dart:convert';
// import 'package:http/http.dart' as http;
// import 'dart:async';

// class Character {
//   final String name;
//   String? vision;
//   String? apiname;
//   String? nation;

//   int rating = 10;
//   Character(this.name);

//   void fetchData() async {
//     apiname = name.toLowerCase();
//     String apiUrl = "https://genshin.jmp.blue/characters/$apiname";

//     try {
//       final response = await http.get(Uri.parse(apiUrl));

//       if (response.statusCode == 200) {
//         Map<String, dynamic> responseData = json.decode(response.body);

//         vision = responseData['vision'];
//         nation = responseData['nation'];

//         print(vision);
//       } else {
//         print("Error: ${response.statusCode}");
//       }
//     } catch (exception) {
//       print("ERROR");
//       // Set default values or throw a custom exception as needed.
//     }
//   }
// }

import 'dart:convert';
import 'package:http/http.dart' as http;

class Character {
  final String name;
  String? vision;
  String? apiname;
  String? nation;

  int rating = 10;

  Character(this.name);

  Future<void> fetchData() async {
    final String apiUrl = "https://genshin.jmp.blue/characters/$apiname";

    try {
      final response = await http.get(Uri.parse(apiUrl));

      if (response.statusCode == 200) {
        // Parse the JSON data
        Map<String, dynamic> responseData = json.decode(response.body);

        // Extract only the "vision" and "nation" fields
        vision = responseData['vision'];
        nation = responseData['nation'];

        // You can add more fields extraction if needed

        print("$name data: $vision, $nation");
      } else {
        print("Error: ${response.statusCode}");
      }
    } catch (e) {
      print("Error: $e");
    }
  }
}
