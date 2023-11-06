import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class SpeedForm extends StatefulWidget {
  const SpeedForm({Key? key}) : super(key: key);

  @override
  State<SpeedForm> createState() => _SpeedForm();
}

class _SpeedForm extends State<SpeedForm> {
  final GlobalKey<FormBuilderState> _fbKey = GlobalKey<FormBuilderState>();

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: FormBuilder(
          key: _fbKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              const Center(
                child: Text(
                  'Speed Form',
                  style: TextStyle(
                    fontSize: 24.0,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
              const SizedBox(height: 8.0),
              const Center(
                child: Text('Form to get data related to vehicles speed',
                    textAlign: TextAlign.center),
              ),
              const Divider(
                thickness: 40.0,
                color: Colors.transparent,
              ),
              const Text(
                'Please provide with the speed of the vehicle',
                style: TextStyle(fontWeight: FontWeight.w600),
              ),
              const Text('Please select one of the options shown',
                  style: TextStyle(fontSize: 12, color: Colors.grey)),
              Column(
                children: [
                  FormBuilderRadioGroup(
                    name: 'radio_group',
                    orientation: OptionsOrientation.vertical,
                    decoration: const InputDecoration(
                        border:
                            InputBorder.none), // Set orientation to vertical
                    options: const [
                      FormBuilderFieldOption(value: 'Above 40 km/h'),
                      FormBuilderFieldOption(value: 'Below 40 km/h'),
                      FormBuilderFieldOption(value: '0 km/h'),
                    ],
                  ),
                ],
              ),
              const SizedBox(height: 16.0),
              const Text(
                'Enter remarks',
                style: TextStyle(fontWeight: FontWeight.w600),
              ),
              const SizedBox(height: 8.0),
              FormBuilderTextField(
                name: 'text_field',
                decoration: const InputDecoration(
                  hintText: 'Enter your remarks here',
                  border: OutlineInputBorder(),
                ),
              ),
              const SizedBox(height: 16.0),
              const Text(
                'Please provide the hightest speed of the vehicle',
                style: TextStyle(fontWeight: FontWeight.w600),
              ),
              const Text('Please select one of the options shown',
                  style: TextStyle(fontSize: 12, color: Colors.grey)),
              const SizedBox(height: 8.0),
              Container(
                decoration: BoxDecoration(
                  border: Border.all(color: Colors.grey),
                  borderRadius: BorderRadius.circular(5.0),
                ),
                child: FormBuilderDropdown(
                  name: 'dropdown_field',
                  decoration: const InputDecoration(
                    hintText: 'Select speed',
                    contentPadding: EdgeInsets.symmetric(
                        horizontal: 10.0), // Adjust the padding as needed
                  ),
                  items: const [
                    DropdownMenuItem(
                      value: '220',
                      child: Text('220 km/h'),
                    ),
                    DropdownMenuItem(
                      value: '250',
                      child: Text('250 km/h'),
                    ),
                  ],
                ),
              ),
              const SizedBox(height: 16.0),
              const Text(
                'Please provide the vehicle speed past 1 hour',
                style: TextStyle(fontWeight: FontWeight.w600),
              ),
              const Text(
                'Please select one or more of the options shown',
                style: TextStyle(fontSize: 12, color: Colors.grey),
              ),
              const SizedBox(height: 8.0),
              FormBuilderCheckbox(
                name: 'checkbox_20',
                title: const Text(
                  '20 km/h',
                  style: TextStyle(fontSize: 16),
                ),
              ),
              FormBuilderCheckbox(
                name: 'checkbox_30',
                title: const Text(
                  '30 km/h',
                  style: TextStyle(fontSize: 16),
                ),
              ),
              FormBuilderCheckbox(
                name: 'checkbox_40',
                title: const Text(
                  '40 km/h',
                  style: TextStyle(fontSize: 16),
                ),
              ),
              FormBuilderCheckbox(
                name: 'checkbox_0',
                title: const Text(
                  '50 km/h',
                  style: TextStyle(fontSize: 16),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
