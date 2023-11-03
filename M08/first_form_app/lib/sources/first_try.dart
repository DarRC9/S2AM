import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';

// ignore: camel_case_types
class firstTry extends StatefulWidget {
  const firstTry({Key? key}) : super(key: key);

  @override
  State<firstTry> createState() => _firstTry();
}

// ignore: camel_case_types
class _firstTry extends State<firstTry> {
  final GlobalKey<FormBuilderState> _fbKey = GlobalKey<FormBuilderState>();

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: FormBuilder(
        key: _fbKey,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const Text(
              'Title',
              style: TextStyle(
                fontSize: 24.0,
                fontWeight: FontWeight.bold,
              ),
            ),
            const SizedBox(height: 8.0),
            const Text('Description'),
            const SizedBox(height: 16.0),
            const Text(
              'Question',
              style: TextStyle(
                fontSize: 18.0,
                fontWeight: FontWeight.bold,
              ),
            ),
            const Text('Explanation of the question'),
            Column(
              children: [
                FormBuilderRadioGroup(
                  name: 'radio_group',
                  decoration: InputDecoration(
                    labelText: 'Please select one of the options shown',
                  ),
                  options: [
                    FormBuilderFieldOption(value: 'Option 1'),
                  ],
                ),
                FormBuilderRadioGroup(
                  name: 'radio_group',
                  decoration: InputDecoration(
                    contentPadding: EdgeInsets.zero,
                  ),
                  options: [
                    FormBuilderFieldOption(value: 'Option 4'),
                  ],
                ),
                FormBuilderRadioGroup(
                  name: 'radio_group',
                  decoration: InputDecoration(
                    contentPadding: EdgeInsets.zero,
                  ),
                  options: [
                    FormBuilderFieldOption(value: 'Option 7'),
                  ],
                ),
              ],
            ),
            const SizedBox(height: 16.0),
            const Text('Additional Text'),
            const SizedBox(height: 8.0),
            FormBuilderTextField(
              name: 'text_field',
              decoration: const InputDecoration(
                hintText: 'Input Field',
                border: OutlineInputBorder(),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
