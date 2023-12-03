import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'package:movies_app/api/api.dart';
import 'package:movies_app/api/api_service.dart';
import 'package:movies_app/models/person.dart';
import 'package:movies_app/models/movie.dart';
import 'package:movies_app/widgets/person_item.dart';

class PersonDetailsScreen extends StatelessWidget {
  const PersonDetailsScreen({
    Key? key,
    required this.person,
  }) : super(key: key);

  final Person person;

  @override
  Widget build(BuildContext context) {
    ApiService.getPersonMovies(person.id);
    String backgroundUrl =
        "https://images.unsplash.com/photo-1669833593439-6db11b5bc570?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDEyfHx8ZW58MHx8fHx8&w=1000&q=80";

    return SafeArea(
      child: Scaffold(
        body: SingleChildScrollView(
          child: Column(
            children: [
              Padding(
                padding: const EdgeInsets.only(left: 24, right: 24, top: 34),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    IconButton(
                      tooltip: 'Back to home',
                      onPressed: () => Get.back(),
                      icon: const Icon(
                        Icons.arrow_back_ios,
                        color: Colors.white,
                      ),
                    ),
                    const Text(
                      'Person Details',
                      style: TextStyle(
                        fontWeight: FontWeight.w400,
                        fontSize: 24,
                      ),
                    ),
                  ],
                ),
              ),
              SizedBox(
                height: 330,
                child: Stack(
                  children: [
                    ClipRRect(
                      borderRadius: const BorderRadius.only(
                        bottomLeft: Radius.circular(16),
                        bottomRight: Radius.circular(16),
                      ),
                      child: Image.network(
                        backgroundUrl,
                        width: Get.width,
                        height: 250,
                        fit: BoxFit.cover,
                        errorBuilder: (_, __, ___) => const Align(
                          alignment: Alignment.center,
                          child: Icon(
                            Icons.broken_image,
                            size: 250,
                          ),
                        ),
                      ),
                    ),
                    Container(
                      margin: const EdgeInsets.only(left: 30),
                      child: Align(
                        alignment: Alignment.bottomLeft,
                        child: ClipRRect(
                          borderRadius: BorderRadius.circular(16),
                          child: Image.network(
                            Api.imageBaseUrl + person.profilePath,
                            width: 120,
                            height: 160,
                            fit: BoxFit.cover,
                          ),
                        ),
                      ),
                    ),
                    Positioned(
                      top: 255,
                      left: 155,
                      child: SizedBox(
                        width: 230,
                        child: Text(
                          person.name,
                          style: const TextStyle(
                            fontSize: 26,
                            fontWeight: FontWeight.w500,
                          ),
                        ),
                      ),
                    ),
                    Positioned(
                      top: 200,
                      right: 30,
                      child: Container(
                        padding: const EdgeInsets.symmetric(
                            horizontal: 8, vertical: 3),
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(16),
                          color: const Color.fromRGBO(37, 40, 54, 0.52),
                        ),
                        child: Row(
                          children: [
                            SvgPicture.asset('assets/Star.svg'),
                            const SizedBox(width: 5),
                            Text(
                              person.popularity
                                  .toString(), // Display the popularity rating
                              style: const TextStyle(
                                fontWeight: FontWeight.w400,
                                color: Color(0xFFFF8700),
                              ),
                            ),
                          ],
                        ),
                      ),
                    ),
                  ],
                ),
              ),
              const SizedBox(height: 20),
              Container(
                padding: const EdgeInsets.only(left: 30),
                child: Align(
                  alignment: Alignment.centerLeft,
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      const SizedBox(height: 10),
                      Text(
                        'Gender: ${(person.gender == 1 ? "Female" : "Male")}',
                        style: const TextStyle(fontSize: 16),
                      ),
                      const SizedBox(height: 10),
                      Text(
                        'Known for department: ${person.knownForDepartment}',
                        style: const TextStyle(fontSize: 16),
                      ),
                      const SizedBox(height: 10),
                      Text(
                        'Popularity rating: ${person.popularity}',
                        style: const TextStyle(fontSize: 16),
                      ),
                    ],
                  ),
                ),
              ),
              const SizedBox(height: 20),
              const Padding(
                padding: EdgeInsets.symmetric(vertical: 16),
                child: Text(
                  'Movies known for',
                  style: TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
              SizedBox(
                height: 500,
                child: ListView.separated(
                  itemCount: person.getMoviesWithPosters().length,
                  shrinkWrap: true,
                  scrollDirection: Axis.horizontal,
                  separatorBuilder: (_, __) => const SizedBox(width: 20),
                  itemBuilder: (_, index) {
                    Movie movie = person.getMoviesWithPosters()[index];
                    return PersonItem(movie: movie, index: index + 1);
                  },
                ),
              ),
              const SizedBox(height: 30)
            ],
          ),
        ),
      ),
    );
  }
}
