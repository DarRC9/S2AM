import 'package:first_form_app/sources/speed_form.dart';
import 'package:first_form_app/sources/stepper_form.dart';
import 'package:first_form_app/sources/fast_form.dart';
import 'package:first_form_app/sources/custom_form.dart';

import 'package:flutter/material.dart';
import 'package:flutter_localizations/flutter_localizations.dart';
import 'package:form_builder_validators/form_builder_validators.dart';

import 'code_page.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Dario Rua',
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
          primarySwatch: Colors.deepPurple,
          appBarTheme: const AppBarTheme(
            backgroundColor: Colors.deepPurple,
          )),
      localizationsDelegates: const [
        FormBuilderLocalizations.delegate,
        ...GlobalMaterialLocalizations.delegates,
        GlobalWidgetsLocalizations.delegate,
      ],
      supportedLocales: FormBuilderLocalizations.supportedLocales,
      home: const _HomePage(),
    );
  }
}

class _HomePage extends StatelessWidget {
  const _HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return CodePage(
      title: 'Dario Rua S2AM',
      child: ListView(
        children: <Widget>[
          ListTile(
            title: const Text('Speed Form'),
            trailing: const Icon(Icons.arrow_right_sharp),
            onTap: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) {
                    return const CodePage(
                      title: 'Speed Form Dario Rua',
                      child: SpeedForm(),
                    );
                  },
                ),
              );
            },
          ),
          const Divider(),
          ListTile(
            title: const Text('Stepper Form'),
            trailing: const Icon(Icons.arrow_right_sharp),
            onTap: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) {
                    return const CodePage(
                      title: 'Stepper Form Dario Rua',
                      child: StepperForm(),
                    );
                  },
                ),
              );
            },
          ),
          const Divider(),
          ListTile(
            title: const Text('Fast Form'),
            trailing: const Icon(Icons.arrow_right_sharp),
            onTap: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) {
                    return const CodePage(
                      title: 'Fast Form Dario Rua',
                      child: FastForm(),
                    );
                  },
                ),
              );
            },
          ),
          const Divider(),
          ListTile(
            title: const Text('Custom Form'),
            trailing: const Icon(Icons.arrow_right_sharp),
            onTap: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) {
                    return const CodePage(
                      title: 'Custom Form Dario Rua',
                      child: MediaListForm(),
                    );
                  },
                ),
              );
            },
          ),
        ],
      ),
    );
  }
}
