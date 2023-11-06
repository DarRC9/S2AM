import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

class FastForm extends StatefulWidget {
  const FastForm({Key? key}) : super(key: key);
  @override
  State<FastForm> createState() => _FastFormState();
}

class _FastFormState extends State<FastForm> {
  final _formKey = GlobalKey<FormBuilderState>();

  InputDecoration _inputDecoration(
      {required String labelText, required IconData icon}) {
    return InputDecoration(
      labelText: labelText,
      labelStyle: const TextStyle(fontSize: 18),
      border: OutlineInputBorder(
        borderRadius: BorderRadius.circular(10.0),
        borderSide: BorderSide(color: Colors.grey.shade300),
      ),
      prefixIcon: Icon(icon, color: Colors.grey),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: FormBuilder(
        key: _formKey,
        child: SingleChildScrollView(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            children: <Widget>[
              FormBuilderTextField(
                name: 'name',
                decoration:
                    _inputDecoration(labelText: 'Name', icon: Icons.person_4),
              ),
              const SizedBox(height: 20),
              FormBuilderDropdown(
                name: 'Working Location',
                decoration: _inputDecoration(
                    labelText: 'Select Location', icon: Icons.location_on),
                items: ['Spain', 'France', 'Germany', 'Italy']
                    .map((country) => DropdownMenuItem(
                          value: country,
                          child: Text(country),
                        ))
                    .toList(growable: false),
              ),
              const SizedBox(height: 20),
              FormBuilderDateTimePicker(
                name: '',
                inputType: InputType.date,
                decoration: _inputDecoration(
                    labelText: 'Day of Employement',
                    icon: Icons.calendar_today),
              ),
              const SizedBox(height: 20),
              FormBuilderSwitch(
                name: 'e-work',
                title: const Text('Do you e-work?',
                    style: TextStyle(fontSize: 18, color: Colors.grey)),
                decoration:
                    _inputDecoration(labelText: 'E-work', icon: Icons.computer),
              ),
              const SizedBox(height: 20),
              FormBuilderRadioGroup(
                name: 'device',
                decoration: _inputDecoration(
                    labelText: 'Which device you use?', icon: Icons.devices),
                options: const [
                  FormBuilderFieldOption(
                      value: 'laptop', child: Text('laptop')),
                  FormBuilderFieldOption(
                      value: 'mobile', child: Text('mobile')),
                  FormBuilderFieldOption(
                      value: 'desktop', child: Text('desktop')),
                ],
              ),
              const SizedBox(height: 20),
              FormBuilderFilterChip(
                name: 'Working Environments',
                decoration: _inputDecoration(
                    labelText: 'Select Environments', icon: Icons.category),
                options: const [
                  FormBuilderChipOption(
                    value: 'Flutter',
                    child: Text('Flutter'),
                  ),
                  FormBuilderChipOption(
                    value: 'Android',
                    child: Text('Android'),
                  ),
                  FormBuilderChipOption(
                    value: 'Chrome OS',
                    child: Text('Chrome OS'),
                  ),
                ],
                selectedColor: Colors.deepPurpleAccent,
                spacing: 10.0,
                runSpacing: 5.0,
              ),
              const SizedBox(height: 20),
              ElevatedButton(
                onPressed: () {
                  print(_formKey.currentState?.value);
                },
                child: const Text('Submit'),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
