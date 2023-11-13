// import 'package:genshin_api_app/character_model.dart';
// import 'character_detail_page.dart';
// import 'package:flutter/material.dart';

// class CharacterCard extends StatefulWidget {
//   final Character character;

//   const CharacterCard(this.character, {super.key});

//   @override
//   // ignore: library_private_types_in_public_api, no_logic_in_create_state
//   _CharacterCardState createState() => _CharacterCardState(character);
// }

// class _CharacterCardState extends State<CharacterCard> {
//   Character character;
//   String? renderUrl;

//   _CharacterCardState(this.character);

//   @override
//   void initState() {
//     super.initState();
//     renderCharacterPic();
//   }

//   Widget get characterImage {
//     var characterAvatar = Hero(
//       tag: character,
//       child: Container(
//         width: 100.0,
//         height: 100.0,
//         decoration: BoxDecoration(
//             shape: BoxShape.circle,
//             image: DecorationImage(
//                 fit: BoxFit.cover, image: NetworkImage(renderUrl ?? ''))),
//       ),
//     );

//     var placeholder = Container(
//       width: 100.0,
//       height: 100.0,
//       decoration: const BoxDecoration(
//           shape: BoxShape.circle,
//           gradient: LinearGradient(
//               begin: Alignment.topLeft,
//               end: Alignment.bottomRight,
//               colors: [
//                 Colors.black54,
//                 Colors.black,
//                 Color.fromARGB(255, 84, 110, 122)
//               ])),
//       alignment: Alignment.center,
//       child: const Text(
//         'DIGI',
//         textAlign: TextAlign.center,
//       ),
//     );

//     var crossFade = AnimatedCrossFade(
//       firstChild: placeholder,
//       secondChild: characterAvatar,
//       // ignore: unnecessary_null_comparison
//       crossFadeState: renderUrl == null
//           ? CrossFadeState.showFirst
//           : CrossFadeState.showSecond,
//       duration: const Duration(milliseconds: 1000),
//     );

//     return crossFade;
//   }

//   void renderCharacterPic() async {
//     await character.getImageUrl();
//     if (mounted) {
//       setState(() {
//         renderUrl = character.imageUrl;
//       });
//     }
//   }

//   Widget get characterCard {
//     return Positioned(
//       right: 0.0,
//       child: SizedBox(
//         width: 290,
//         height: 115,
//         child: Card(
//           shape:
//               RoundedRectangleBorder(borderRadius: BorderRadius.circular(15.0)),
//           color: const Color(0xFFF8F8F8),
//           child: Padding(
//             padding: const EdgeInsets.only(top: 8, bottom: 8, left: 64),
//             child: Column(
//               crossAxisAlignment: CrossAxisAlignment.start,
//               mainAxisAlignment: MainAxisAlignment.spaceAround,
//               children: <Widget>[
//                 Text(
//                   widget.character.name,
//                   style:
//                       const TextStyle(color: Color(0xFF000600), fontSize: 27.0),
//                 ),
//                 Row(
//                   children: <Widget>[
//                     const Icon(Icons.star, color: Color(0xFF000600)),
//                     Text(': ${widget.character.rating}/10',
//                         style: const TextStyle(
//                             color: Color(0xFF000600), fontSize: 14.0))
//                   ],
//                 )
//               ],
//             ),
//           ),
//         ),
//       ),
//     );
//   }

//   showCharacterDetailPage() {
//     Navigator.of(context).push(MaterialPageRoute(builder: (context) {
//       return CharacterDetailPage(character);
//     }));
//   }

//   @override
//   Widget build(BuildContext context) {
//     return InkWell(
//       onTap: () => showCharacterDetailPage(),
//       child: Padding(
//         padding: const EdgeInsets.symmetric(horizontal: 16.0, vertical: 8.0),
//         child: SizedBox(
//           height: 115.0,
//           child: Stack(
//             children: <Widget>[
//               characterCard,
//               Positioned(top: 7.5, child: characterImage),
//             ],
//           ),
//         ),
//       ),
//     );
//   }
// }
import 'package:extended_image/extended_image.dart';
import 'package:flutter/material.dart';
import 'character_model.dart';
import 'character_detail_page.dart';

class CharacterCard extends StatefulWidget {
  final Character character;

  const CharacterCard(this.character, {Key? key}) : super(key: key);

  @override
  // ignore: library_private_types_in_public_api, no_logic_in_create_state
  _CharacterCardState createState() => _CharacterCardState(character);
}

class _CharacterCardState extends State<CharacterCard> {
  Character character;
  String? renderUrl;

  _CharacterCardState(this.character);

  @override
  void initState() {
    super.initState();
    // renderCharacterPic();
  }

  // Widget get characterImage {
  //   var characterAvatar = Hero(
  //     tag: character,
  //     child: Container(
  //       width: 100.0,
  //       height: 100.0,
  //       child: renderUrl != null
  //           ? ExtendedImage.network(
  //               renderUrl!,
  //               fit: BoxFit.cover,
  //               cache: true,
  //               enableLoadState: false,
  //             )
  //           : Container(),
  //     ),
  //   );

  //   var placeholder = Container(
  //     width: 100.0,
  //     height: 100.0,
  //     decoration: const BoxDecoration(
  //       shape: BoxShape.circle,
  //       gradient: LinearGradient(
  //         begin: Alignment.topLeft,
  //         end: Alignment.bottomRight,
  //         colors: [
  //           Colors.black54,
  //           Colors.black,
  //           Color.fromARGB(255, 84, 110, 122),
  //         ],
  //       ),
  //     ),
  //     alignment: Alignment.center,
  //     child: const Text(
  //       'DIGI',
  //       textAlign: TextAlign.center,
  //     ),
  //   );

  //   var crossFade = AnimatedCrossFade(
  //     firstChild: placeholder,
  //     secondChild: characterAvatar,
  //     crossFadeState: renderUrl == null
  //         ? CrossFadeState.showFirst
  //         : CrossFadeState.showSecond,
  //     duration: const Duration(milliseconds: 1000),
  //   );

  //   return crossFade;
  // }

  // void renderCharacterPic() async {
  //   await character.getDataFromApi();
  //   if (mounted) {
  //     setState(() {
  //       renderUrl = character.imageWebp;
  //     });
  //   }
  // }

  Widget get characterCard {
    return Positioned(
      right: 0.0,
      child: SizedBox(
        width: 290,
        height: 115,
        child: Card(
          shape:
              RoundedRectangleBorder(borderRadius: BorderRadius.circular(15.0)),
          color: const Color(0xFFF8F8F8),
          child: Padding(
            padding: const EdgeInsets.only(top: 8, bottom: 8, left: 64),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              mainAxisAlignment: MainAxisAlignment.spaceAround,
              children: <Widget>[
                Text(
                  widget.character.name,
                  style:
                      const TextStyle(color: Color(0xFF000600), fontSize: 27.0),
                ),
                Row(
                  children: <Widget>[
                    const Icon(Icons.star, color: Color(0xFF000600)),
                    Text(': ${widget.character.rating}/10',
                        style: const TextStyle(
                            color: Color(0xFF000600), fontSize: 14.0))
                  ],
                )
              ],
            ),
          ),
        ),
      ),
    );
  }

  showCharacterDetailPage() {
    Navigator.of(context).push(MaterialPageRoute(builder: (context) {
      return CharacterDetailPage(character);
    }));
  }

  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: () => showCharacterDetailPage(),
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 16.0, vertical: 8.0),
        child: SizedBox(
          height: 115.0,
          child: Stack(
            children: <Widget>[
              characterCard,
              // Positioned(top: 7.5, child: characterImage),
            ],
          ),
        ),
      ),
    );
  }
}
