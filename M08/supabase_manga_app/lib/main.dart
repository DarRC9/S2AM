import 'package:flutter/material.dart';
import 'package:supabase_flutter/supabase_flutter.dart';
import 'package:supabase_manga_app/pages/account_page.dart';
import 'package:supabase_manga_app/pages/login_page.dart';
import 'package:supabase_manga_app/pages/splash_page.dart';

Future<void> main() async {
  await Supabase.initialize(
    url: 'https://gwhrpkcwemlebclcdedl.supabase.co',
    anonKey:
        'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Imd3aHJwa2N3ZW1sZWJjbGNkZWRsIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDI5MTI3NDQsImV4cCI6MjAxODQ4ODc0NH0.DEetcyT2oSyRKJacQ-P11gAuXXbMtLdrjMvUeOxy2ns',
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
            foregroundColor: Colors.purple[300],
          ),
        ),
        elevatedButtonTheme: ElevatedButtonThemeData(
          style: ElevatedButton.styleFrom(
            foregroundColor: Colors.purple[300],
          ),
        ),
      ),
      initialRoute: '/',
      routes: <String, WidgetBuilder>{
        '/': (_) => const SplashPage(),
        '/login': (_) => const LoginPage(),
        '/account': (_) => const AccountPage(),
      },
    );
  }
}
