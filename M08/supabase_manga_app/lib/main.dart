import 'package:flutter/material.dart';
import 'package:supabase_flutter/supabase_flutter.dart';
import 'package:supabase_manga_app/pages/account_page.dart';
import 'package:supabase_manga_app/pages/login_page.dart';
import 'package:supabase_manga_app/pages/splash_page.dart';
import 'package:supabase_manga_app/pages/sign_up_page.dart';
import 'package:supabase_manga_app/pages/login_password_page.dart';

Future<void> main() async {
  await Supabase.initialize(
    url: 'https://gdbhnnihvwyoicslgwhh.supabase.co',
    anonKey:
        'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImdkYmhubmlodnd5b2ljc2xnd2hoIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDQ5MDM2MTksImV4cCI6MjAyMDQ3OTYxOX0.dON5oOOz8bpdH2GhPn5l8A_yNj772ttYvIDzJOubLtg',
  );
  runApp(MyApp());
}

final supabase = Supabase.instance.client;

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Supabase Flutter Dario Rua S2AM',
      theme: ThemeData.dark().copyWith(
        scaffoldBackgroundColor: Colors.grey[900],
        primaryColor: Colors.purple[300],
        textTheme: TextTheme(
          bodyMedium: TextStyle(color: Colors.white),
        ),
        textButtonTheme: TextButtonThemeData(
          style: TextButton.styleFrom(
            foregroundColor: Colors.white,
            backgroundColor: Colors.purple[900],
          ),
        ),
        elevatedButtonTheme: ElevatedButtonThemeData(
          style: ElevatedButton.styleFrom(
            foregroundColor: Colors.white,
            backgroundColor: Colors.purple[900],
          ),
        ),
      ),
      initialRoute: '/',
      routes: <String, WidgetBuilder>{
        '/': (_) => const SplashPage(),
        '/login': (_) => const LoginPage(),
        '/loginPassword': (_) => const LoginPasswordPage(),
        '/account': (_) => const AccountPage(),
        '/signup': (_) => const SignUpPage(),
      },
    );
  }
}
