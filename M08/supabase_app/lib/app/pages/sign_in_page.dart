import 'package:auto_route/auto_route.dart';
import 'package:flutter/material.dart';
import 'package:supabase_app/app/repository/auth_repository.dart';
import 'package:supabase_app/core/routes/app_router.dart';
import 'package:supabase_app/injectable.dart';

class SignInPage extends StatefulWidget {
  const SignInPage({Key? key}) : super(key: key);

  @override
  State<SignInPage> createState() => _SignInPageState();
}

class _SignInPageState extends State<SignInPage> {
  String email = "";
  String password = "";

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Scaffold(
        body: Column(
          children: [
            const Text("Sign in"),
            TextField(
              decoration: const InputDecoration(
                hintText: "Email",
              ),
              onChanged: (value) {
                setState(() => email = value);
              },
            ),
            TextField(
              decoration: const InputDecoration(
                hintText: "Password",
              ),
              obscureText: true,
              onChanged: (value) {
                setState(() => password = value);
              },
            ),
            ElevatedButton(
              onPressed: () => _onClickSignIn(context),
              child: const Text('Sign in'),
            ),
            ElevatedButton(
              onPressed: () => _onClickGoToSignUp(context),
              child: const Text('Go to sign up'),
            ),
          ],
        ),
      ),
    );
  }

  Future<void> _onClickSignIn(BuildContext context) async {
    try {
      await getIt<AuthRepository>().signInEmailAndPassword(email, password);
    } catch (e) {
      // TODO: Show proper error to users
      print("Sign in error");
      print(e);
    }
  }

  void _onClickGoToSignUp(BuildContext context) {
    context.router.push(const SignUpRoute());
  }
}