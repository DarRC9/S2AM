import 'package:get/get.dart';
import 'package:movies_app/api/api_service.dart';
import 'package:movies_app/models/person.dart';

class PersonsController extends GetxController {
  var isLoading = false.obs;
  var popularPersons = <Person>[].obs;

  @override
  void onInit() async {
    isLoading.value = true;
    popularPersons.value = (await ApiService.getPopularPersons())!;
    isLoading.value = false;
    super.onInit();
  }
}
