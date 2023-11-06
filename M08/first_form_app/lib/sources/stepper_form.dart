// import 'package:flutter/material.dart';
// import 'package:flutter_form_builder/flutter_form_builder.dart';

// void main() {
//   runApp(const MaterialApp(
//     home: StepperForm(),
//   ));
// }

// class StepperForm extends StatefulWidget {
//   const StepperForm({Key? key}) : super(key: key);

//   @override
//   State<StepperForm> createState() => _StepperForm();
// }

// class _StepperForm extends State<StepperForm> {
//   final PageController _pageController = PageController();
//   final List<GlobalKey<FormBuilderState>> _fbKeys = [
//     GlobalKey<FormBuilderState>(),
//     GlobalKey<FormBuilderState>(),
//     GlobalKey<FormBuilderState>(),
//   ];
//   final List<IconData> icons = [Icons.person, Icons.edit, Icons.check];
//   final List<String> titles = ['Personal', 'Contact', 'Upload'];
//   final List<IconData> personalIcons = [
//     Icons.person,
//     Icons.person_2,
//     Icons.credit_card_outlined
//   ];
//   final List<IconData> contactIcons = [
//     Icons.email,
//     Icons.home,
//     Icons.phone_android
//   ];
//   final List<IconData> uploadIcons = [
//     Icons.verified_user,
//     Icons.upload_file,
//     Icons.upload_file
//   ];

//   int _currentPage = 0;

//   void _nextPage() {
//     if (_currentPage < 2) {
//       _pageController.nextPage(
//           duration: const Duration(milliseconds: 500), curve: Curves.ease);
//       setState(() {
//         _currentPage++;
//       });
//     }
//   }

//   void _previousPage() {
//     if (_currentPage > 0) {
//       _pageController.previousPage(
//           duration: const Duration(milliseconds: 500), curve: Curves.ease);
//       setState(() {
//         _currentPage--;
//       });
//     }
//   }

//   @override
//   Widget build(BuildContext context) {
//     return Scaffold(
//       body: Column(
//         children: [
//           _buildHeader(),
//           Expanded(
//             child: PageView(
//               controller: _pageController,
//               physics: const NeverScrollableScrollPhysics(),
//               children: [
//                 _buildStep(context, _fbKeys[0], icons[0], personalIcons,
//                     'Personal', 'Name', 'Surname', 'DNI'),
//                 _buildStep(context, _fbKeys[1], icons[1], contactIcons,
//                     'Contact', 'Email', 'Address', 'Mobile Number'),
//                 _buildStep(context, _fbKeys[2], icons[2], uploadIcons, 'Upload',
//                     'Verification code', 'Upload ID', 'Upload Photo'),
//               ],
//             ),
//           ),
//           Padding(
//             padding: const EdgeInsets.all(8.0),
//             child: Row(
//               mainAxisAlignment: MainAxisAlignment.spaceAround,
//               children: [
//                 ElevatedButton(
//                   onPressed: _previousPage,
//                   child: const Text('Previous'),
//                 ),
//                 ElevatedButton(
//                   onPressed: _nextPage,
//                   child: _currentPage == 2
//                       ? const Text('Submit')
//                       : const Text('Continue'),
//                 ),
//               ],
//             ),
//           ),
//         ],
//       ),
//     );
//   }

//   Widget _buildHeader() {
//     return Container(
//       padding: const EdgeInsets.all(8.0),
//       child: Row(
//         children: [
//           for (int i = 0; i < titles.length; i++)
//             Row(
//               children: [
//                 Padding(
//                   padding: const EdgeInsets.only(left: 50.0),
//                   child: Column(
//                     children: [
//                       CircleAvatar(
//                         backgroundColor: Colors.blue,
//                         radius: 20.0,
//                         child: Icon(icons[i]),
//                       ),
//                       const SizedBox(width: 10.0),
//                     ],
//                   ),
//                 ),
//                 const SizedBox(width: 8.0),
//                 Text(titles[i],
//                     style: const TextStyle(fontWeight: FontWeight.bold)),
//                 if (i < titles.length - 1) const SizedBox(width: 50.0),
//                 if (i < titles.length - 1)
//                   Container(
//                     width: 30.0,
//                     height: 0.5,
//                     color: Colors.black,
//                   ),
//                 if (i < titles.length - 1) const SizedBox(width: 5.0),
//               ],
//             ),
//         ],
//       ),
//     );
//   }

//   Widget _buildStep(
//     BuildContext context,
//     GlobalKey<FormBuilderState> key,
//     IconData icon,
//     List<IconData> fieldsIcons,
//     String title,
//     String hintText1,
//     String hintText2,
//     String hintText3,
//   ) {
//     return FormBuilder(
//       key: key,
//       child: Padding(
//         padding: const EdgeInsets.all(16.0),
//         child: Column(
//           crossAxisAlignment: CrossAxisAlignment.start,
//           children: [
//             FormBuilderTextField(
//               name: 'Email',
//               decoration: InputDecoration(
//                 hintText: hintText1,
//                 border: const OutlineInputBorder(),
//                 prefixIcon: Icon(fieldsIcons[0]), // Add this line
//               ),
//             ),
//             const Divider(
//               color: Colors.transparent,
//               thickness: 3.0,
//             ),
//             FormBuilderTextField(
//               name: 'address',
//               decoration: InputDecoration(
//                 hintText: hintText2,
//                 border: const OutlineInputBorder(),
//                 prefixIcon: Icon(fieldsIcons[1]), // Add this line
//               ),
//             ),
//             const Divider(
//               color: Colors.transparent,
//               thickness: 3.0,
//             ),
//             FormBuilderTextField(
//               name: 'mobile',
//               decoration: InputDecoration(
//                 hintText: hintText3,
//                 border: const OutlineInputBorder(),
//                 prefixIcon: Icon(fieldsIcons[2]), // Add this line
//               ),
//             ),
//             const SizedBox(height: 5.0),
//           ],
//         ),
//       ),
//     );
//   }
// }

import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:form_builder_validators/form_builder_validators.dart';

class StepperForm extends StatefulWidget {
  const StepperForm({Key? key}) : super(key: key);

  @override
  State<StepperForm> createState() => _StepperFormState();
}

class _StepperFormState extends State<StepperForm> {
  final _formKey = GlobalKey<FormBuilderState>();
  int _currentStep = 0;

  InputDecoration _inputDecoration(
      {required String labelText, required IconData icon}) {
    return InputDecoration(
      labelText: labelText,
      border: OutlineInputBorder(
        borderRadius: BorderRadius.circular(10.0),
        borderSide: const BorderSide(color: Colors.deepPurpleAccent),
      ),
      prefixIcon: Icon(icon, color: Colors.deepPurpleAccent),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: FormBuilder(
          key: _formKey,
          child: Theme(
            data: ThemeData(
              primarySwatch: Colors.deepPurple,
            ),
            child: Stepper(
              type: StepperType.horizontal,
              currentStep: _currentStep,
              onStepContinue: () {
                if (_currentStep <= 2) {
                  setState(() => _currentStep += 1);
                }
              },
              onStepCancel: () {
                if (_currentStep > 0) {
                  setState(() => _currentStep -= 1);
                }
              },
              controlsBuilder: (context, details) {
                return Column(
                  children: [
                    const SizedBox(height: 20),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        if (_currentStep > 0)
                          TextButton(
                            onPressed: details.onStepCancel,
                            style: ButtonStyle(
                              foregroundColor: MaterialStateColor.resolveWith(
                                  (states) => Colors.deepPurpleAccent),
                            ),
                            child: const Text('Back'),
                          ),
                        if (_currentStep < 2)
                          ElevatedButton(
                            onPressed: details.onStepContinue,
                            style: ButtonStyle(
                              backgroundColor: MaterialStateColor.resolveWith(
                                  (states) => Colors.deepPurpleAccent),
                            ),
                            child: const Text('Next'),
                          ),
                        if (_currentStep == 2)
                          ElevatedButton(
                            onPressed: () {
                              print(_formKey.currentState?.value);
                              Navigator.pop(context);
                            },
                            style: ButtonStyle(
                              backgroundColor: MaterialStateColor.resolveWith(
                                  (states) => Colors.deepPurpleAccent),
                            ),
                            child: const Text('Upload'),
                          ),
                      ],
                    ),
                  ],
                );
              },
              steps: [
                Step(
                  title: const Text('Personal'),
                  content: Column(
                    children: [
                      FormBuilderTextField(
                        name: 'name',
                        decoration: _inputDecoration(
                          labelText: 'Name',
                          icon: Icons.person,
                        ),
                        validator: FormBuilderValidators.required(),
                      ),
                      const SizedBox(height: 10),
                      FormBuilderTextField(
                        name: 'surname',
                        decoration: _inputDecoration(
                          labelText: 'Surname',
                          icon: Icons.person,
                        ),
                        validator: FormBuilderValidators.required(),
                      ),
                      const SizedBox(height: 10),
                      FormBuilderTextField(
                        name: 'dni',
                        decoration: _inputDecoration(
                          labelText: 'DNI',
                          icon: Icons.credit_card,
                        ),
                        validator: FormBuilderValidators.compose([
                          FormBuilderValidators.required(),
                          FormBuilderValidators.numeric(),
                          FormBuilderValidators.minLength(9),
                        ]),
                      ),
                    ],
                  ),
                  isActive: _currentStep >= 0,
                  state:
                      _currentStep > 0 ? StepState.complete : StepState.indexed,
                ),
                Step(
                  title: const Text('Contact'),
                  content: Column(
                    children: [
                      FormBuilderTextField(
                        name: 'email',
                        decoration: _inputDecoration(
                          labelText: 'Email',
                          icon: Icons.email,
                        ),
                        validator: FormBuilderValidators.compose([
                          FormBuilderValidators.required(),
                          FormBuilderValidators.email(),
                        ]),
                      ),
                      const SizedBox(height: 10),
                      FormBuilderTextField(
                        name: 'address',
                        decoration: _inputDecoration(
                          labelText: 'Address',
                          icon: Icons.home,
                        ),
                        validator: FormBuilderValidators.required(),
                      ),
                      const SizedBox(height: 10),
                      FormBuilderTextField(
                        name: 'phone',
                        decoration: _inputDecoration(
                          labelText: 'Phone Number',
                          icon: Icons.phone,
                        ),
                        validator: FormBuilderValidators.compose([
                          FormBuilderValidators.required(),
                          FormBuilderValidators.numeric(),
                          FormBuilderValidators.minLength(9),
                        ]),
                      ),
                    ],
                  ),
                  isActive: _currentStep >= 1,
                  state:
                      _currentStep > 1 ? StepState.complete : StepState.indexed,
                ),
                Step(
                  title: const Text('Submit'),
                  content: Column(
                    children: [
                      const Text(
                        'Form Data:',
                        style: TextStyle(
                            fontWeight: FontWeight.bold, fontSize: 25),
                      ),
                      Container(
                        padding: const EdgeInsets.all(12.0),
                        decoration: BoxDecoration(
                          border: Border.all(color: Colors.deepPurpleAccent),
                          borderRadius: BorderRadius.circular(8.0),
                        ),
                        child: Column(children: [
                          Text(
                              "Name: ${_formKey.currentState?.fields['name']?.value}",
                              style:
                                  const TextStyle(fontWeight: FontWeight.bold)),
                          Text(
                              "Surname: ${_formKey.currentState?.fields['surname']?.value}",
                              style:
                                  const TextStyle(fontWeight: FontWeight.bold)),
                          Text(
                              "DNI: ${_formKey.currentState?.fields['dni']?.value}",
                              style:
                                  const TextStyle(fontWeight: FontWeight.bold)),
                          Text(
                              "Email: ${_formKey.currentState?.fields['email']?.value}",
                              style:
                                  const TextStyle(fontWeight: FontWeight.bold)),
                          Text(
                              "Address: ${_formKey.currentState?.fields['address']?.value}",
                              style:
                                  const TextStyle(fontWeight: FontWeight.bold)),
                          Text(
                              "Phone: ${_formKey.currentState?.fields['phone']?.value}",
                              style:
                                  const TextStyle(fontWeight: FontWeight.bold)),
                        ]),
                      )
                    ],
                  ),
                  isActive: _currentStep >= 2,
                  state: _currentStep == 2
                      ? StepState.complete
                      : StepState.indexed,
                ),
              ],
            ),
          )),
    );
  }
}
