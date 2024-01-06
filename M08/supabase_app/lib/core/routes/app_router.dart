/// Make sure to import `auto_route` and `material` (required)
import 'package:auto_route/auto_route.dart';
import 'package:flutter/material.dart';
import 'package:supabase_app/app/pages/home_page.dart';
import 'package:supabase_app/app/pages/sign_in_page.dart';
import 'package:supabase_app/app/pages/sign_up_page.dart';
import 'package:supabase_app/app/pages/splash_screen_page.dart';

part 'app_router.gr.dart';

@MaterialAutoRouter(
  replaceInRouteName: 'Page,Route',
  routes: <AutoRoute>[
    AutoRoute(page: SplashScreenPage, initial: true),
    AutoRoute(page: SignUpPage),
    AutoRoute(page: SignInPage),
    AutoRoute(page: HomePage),
  ],
)
class AppRouter extends _$AppRouter {}
