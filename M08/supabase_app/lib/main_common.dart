import 'package:flutter/material.dart';
import 'package:supabase_app/app.dart';
import 'package:supabase_app/constants.dart';
import 'package:supabase_app/injectable.dart';
import 'package:supabase_flutter/supabase_flutter.dart';

/// Shared `runApp` configuration.
///
/// Used to initialize all required dependencies, packages, and constants.
Future<void> mainCommon() async {
  WidgetsFlutterBinding.ensureInitialized();

  // Dependency injection (injectable)
  configureDependencies();

  await Supabase.initialize(
    url: Constants.supabaseUrl,
    anonKey: Constants.supabaseAnnonKey,
  );

  runApp(const App());
}
