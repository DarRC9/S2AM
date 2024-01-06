import 'package:flutter/material.dart';
import 'package:supabase_manga_app/main.dart';

class SplashPage extends StatefulWidget {
  const SplashPage({super.key});

  @override
  _SplashPageState createState() => _SplashPageState();
}

class _SplashPageState extends State<SplashPage> {
  @override
  void initState() {
    super.initState();
    _redirect();
  }

  Future<void> _redirect() async {
    await Future.delayed(Duration(seconds: 5));
    if (!mounted) {
      return;
    }

    final session = supabase.auth.currentSession;
    if (session != null) {
      Navigator.of(context).pushReplacementNamed('/account');
    } else {
      Navigator.of(context).pushReplacementNamed('/login');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Image.network(
              'https://i.postimg.cc/Y9WKKyF7/logo-white.png',
              height: 100, // Adjust the height as needed
            ),
            SizedBox(height: 30),
            CircularProgressIndicator(
              backgroundColor: Color.fromRGBO(140, 50, 80, 1.0),
            ),
          ],
        ),
      ),
    );
  }
}
