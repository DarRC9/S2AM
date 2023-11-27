// import 'package:flutter/material.dart';
// import 'package:get/get.dart';
// import 'package:movies_app/api/api.dart';
// import 'package:movies_app/models/person.dart';
// import 'package:movies_app/screens/person_details_screen.dart';

// class PersonItem extends StatelessWidget {
//   const PersonItem({
//     Key? key,
//     required this.person,
//   }) : super(key: key);

//   final Person person;

//   @override
//   Widget build(BuildContext context) {
//     return GestureDetector(
//       onTap: () => Get.to(
//         PersonDetailsScreen(person: person),
//       ),
//       child: Container(
//         margin: const EdgeInsets.only(left: 12),
//         child: ClipRRect(
//           borderRadius: BorderRadius.circular(16),
//           child: Image.network(
//             Api.imageBaseUrl + person.profilePath,
//             fit: BoxFit.cover,
//             height: 250, // Adjust the height as needed
//             width: 180, // Adjust the width as needed
//             errorBuilder: (_, __, ___) => const Icon(
//               Icons.broken_image,
//               size: 180,
//             ),
//           ),
//         ),
//       ),
//     );
//   }
// }

// person_item.dart
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:movies_app/api/api.dart';
import 'package:movies_app/models/movie.dart';
import 'package:movies_app/screens/details_screen.dart';

class PersonItem extends StatelessWidget {
  const PersonItem({
    Key? key,
    required this.movie,
    required this.index,
  }) : super(key: key);

  final Movie movie;
  final int index;

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () => Get.to(
        DetailsScreen(movie: movie),
      ),
      child: Container(
        margin: const EdgeInsets.only(left: 12),
        child: ClipRRect(
          borderRadius: BorderRadius.circular(16),
          child: Image.network(
            Api.imageBaseUrl + movie.posterPath,
            fit: BoxFit.cover,
            height: 500,
            width: 280,
            errorBuilder: (_, __, ___) => const Icon(
              Icons.broken_image,
              size: 180,
            ),
          ),
        ),
      ),
    );
  }
}
