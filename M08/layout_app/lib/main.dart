import 'package:flutter/material.dart';

void main() {
  return runApp(MaterialApp(
    home: Scaffold(
        appBar: AppBar(title: const Text("Dario Rua S2AM M08")),
        body: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Container(
              decoration: BoxDecoration(
                color: Colors.red,
                border: Border.all(
                  color: Colors.black,
                  width: 3,
                ),
              ),
              child: const Text("One"),
            ),
            Container(
              decoration: BoxDecoration(
                color: Colors.green,
                border: Border.all(
                  color: Colors.black,
                  width: 3,
                ),
              ),
              child: const Text("Two"),
            ),
            Container(
              decoration: BoxDecoration(
                color: Colors.blue,
                border: Border.all(
                  color: Colors.black,
                  width: 3,
                ),
              ),
              child: const Text("Three"),
            ),
          ],
        )),
  ));
}
