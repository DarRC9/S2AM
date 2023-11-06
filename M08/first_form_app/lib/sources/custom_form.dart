import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:intl/intl.dart';

class MediaListForm extends StatefulWidget {
  const MediaListForm({Key? key}) : super(key: key);

  @override
  State<MediaListForm> createState() => _MediaListFormState();
}

class _MediaListFormState extends State<MediaListForm> {
  final _formKey = GlobalKey<FormBuilderState>();
  final _mediaType = ['Anime', 'Manga'];
  final _releaseYear = ['2000-2005', '2006-2010', '2011--2015', '2016-2020'];

  final String _sliderLabel = 'Episodes in total';

  InputDecoration _inputDecoration(
      {required String labelText, required IconData icon}) {
    return InputDecoration(
      labelText: labelText,
      labelStyle: const TextStyle(fontSize: 14),
      border: const OutlineInputBorder(),
      prefixIcon: Icon(
        icon,
        color: Colors.deepPurpleAccent,
      ),
    );
  }

  void _onChanged(dynamic val) => debugPrint(val.toString());

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
                name: 'username',
                decoration: _inputDecoration(
                  labelText: 'Username',
                  icon: Icons.person,
                ),
              ),
              const SizedBox(height: 20),
              FormBuilderTextField(
                name: 'email',
                decoration: _inputDecoration(
                  labelText: 'Email',
                  icon: Icons.email_rounded,
                ),
                keyboardType: TextInputType.emailAddress,
              ),
              const SizedBox(height: 20),
              FormBuilderDateTimePicker(
                name: 'Reminder hour',
                inputType: InputType.time,
                format: DateFormat('HH:mm'),
                decoration: _inputDecoration(
                  labelText: 'Reminder hour',
                  icon: Icons.access_time,
                ),
              ),
              const SizedBox(height: 20),
              FormBuilderDropdown(
                name: 'Media Type',
                decoration: _inputDecoration(
                  labelText: 'Media Type',
                  icon: Icons.perm_media_rounded,
                ),
                items: _mediaType
                    .map((brand) => DropdownMenuItem(
                          value: brand,
                          child: Text(brand),
                        ))
                    .toList(),
              ),
              const SizedBox(height: 20),
              FormBuilderFilterChip(
                name: 'Genres',
                decoration: _inputDecoration(
                  labelText: 'Genre',
                  icon: Icons.category_rounded,
                ),
                selectedColor: Colors.deepPurpleAccent,
                spacing: 10.0,
                runSpacing: 5.0,
                options: const [
                  FormBuilderChipOption(
                    value: 'Action',
                    child: Text('Action'),
                  ),
                  FormBuilderChipOption(
                    value: 'Adventure',
                    child: Text('Adventure'),
                  ),
                  FormBuilderChipOption(
                    value: 'Comedy',
                    child: Text('Comedy'),
                  ),
                  FormBuilderChipOption(
                    value: 'Drama',
                    child: Text('Drama'),
                  ),
                  FormBuilderChipOption(
                    value: 'Fantasy',
                    child: Text('Fantasy'),
                  ),
                  FormBuilderChipOption(
                    value: 'Horror',
                    child: Text('Horror'),
                  ),
                ],
              ),
              const SizedBox(height: 20),
              FormBuilderDateTimePicker(
                name: 'Started Watching',
                inputType: InputType.date,
                format: DateFormat('dd-MM-yyyy'),
                decoration: _inputDecoration(
                  labelText: 'Started Watching',
                  icon: Icons.calendar_today,
                ),
              ),
              const SizedBox(height: 20),
              FormBuilderChoiceChip(
                name: 'Release Year',
                decoration: _inputDecoration(
                  labelText: 'Release Year',
                  icon: Icons.calendar_today,
                ),
                selectedColor: Colors.deepPurpleAccent,
                spacing: 10.0,
                options: _releaseYear
                    .map((size) => FormBuilderChipOption(
                          value: size,
                          child: Text(size),
                        ))
                    .toList(),
              ),
              const SizedBox(height: 20),
              FormBuilderDateRangePicker(
                  name: 'date_range',
                  firstDate: DateTime(1970),
                  lastDate: DateTime(2030),
                  format: DateFormat('yyyy-MM-dd'),
                  onChanged: _onChanged,
                  decoration: _inputDecoration(
                      labelText: 'Exact Date Range',
                      icon: Icons.date_range_outlined)),
              const SizedBox(height: 20),
              FormBuilderSlider(
                name: 'Nº of episodes/chapters',
                min: 12,
                max: 240,
                initialValue: 12,
                divisions: 4,
                decoration: _inputDecoration(
                  labelText: 'Nº of episodes/chapters',
                  icon: Icons.smart_display_sharp,
                ),
                label: _sliderLabel,
                displayValues: DisplayValues.all,
                numberFormat: NumberFormat(),
              ),
              const SizedBox(height: 20),
              ElevatedButton(
                onPressed: () {
                  if (_formKey.currentState?.saveAndValidate() ?? false) {
                    print(_formKey.currentState?.value);
                  }
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
