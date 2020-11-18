
//文字変換----------------------------------------------------------------------------
function Convert(text) {

    OldText = text;
    console.log(OldText);

    //入力された値がなかった場合
    if (!OldText) {
        return OldText;
    }

    var kanaMap = {
        //ひらがな
        "が": "ｶﾞ", "ぎ": "ｷﾞ", "ぐ": "ｸﾞ", "げ": "ｹﾞ", "ご": "ｺﾞ",
        "ざ": "ｻﾞ", "じ": "ｼﾞ", "ず": "ｽﾞ", "ぜ": "ｾﾞ", "ぞ": "ｿﾞ",
        "だ": "ﾀﾞ", "ぢ": "ﾁﾞ", "づ": "ﾂﾞ", "で": "ﾃﾞ", "ど": "ﾄﾞ",
        "ば": "ﾊﾞ", "び": "ﾋﾞ", "ぶ": "ﾌﾞ", "べ": "ﾍﾞ", "ぼ": "ﾎﾞ",
        "ぱ": "ﾊﾟ", "ぴ": "ﾋﾟ", "ぷ": "ﾌﾟ", "ぺ": "ﾍﾟ", "ぽ": "ﾎﾟ",
        "あ": "ｱ", "い": "ｲ", "う": "ｳ", "え": "ｴ", "お": "ｵ",
        "か": "ｶ", "き": "ｷ", "く": "ｸ", "け": "ｹ", "こ": "ｺ",
        "さ": "ｻ", "し": "ｼ", "す": "ｽ", "せ": "ｾ", "そ": "ｿ",
        "た": "ﾀ", "ち": "ﾁ", "つ": "ﾂ", "て": "ﾃ", "と": "ﾄ",
        "な": "ﾅ", "に": "ﾆ", "ぬ": "ﾇ", "ね": "ﾈ", "の": "ﾉ",
        "は": "ﾊ", "ひ": "ﾋ", "ふ": "ﾌ", "へ": "ﾍ", "ほ": "ﾎ",
        "ま": "ﾏ", "み": "ﾐ", "む": "ﾑ", "め": "ﾒ", "も": "ﾓ",
        "や": "ﾔ", "ゆ": "ﾕ", "よ": "ﾖ",
        "ら": "ﾗ", "り": "ﾘ", "る": "ﾙ", "れ": "ﾚ", "ろ": "ﾛ",
        "わ": "ﾜ", "を": "ｦ", "ん": "ﾝ",
        "ぁ": "ｧ", "ぃ": "ｨ", "ぅ": "ｩ", "ぇ": "ｪ", "ぉ": "ｫ",
        "っ": "ｯ", "ゃ": "ｬ", "ゅ": "ｭ", "ょ": "ｮ",
        //かたかな
        "ガ": "ｶﾞ", "ギ": "ｷﾞ", "グ": "ｸﾞ", "ゲ": "ｹﾞ", "ゴ": "ｺﾞ",
        "ザ": "ｻﾞ", "ジ": "ｼﾞ", "ズ": "ｽﾞ", "ゼ": "ｾﾞ", "ゾ": "ｿﾞ",
        "ダ": "ﾀﾞ", "ヂ": "ﾁﾞ", "ヅ": "ﾂﾞ", "デ": "ﾃﾞ", "ド": "ﾄﾞ",
        "バ": "ﾊﾞ", "ビ": "ﾋﾞ", "ブ": "ﾌﾞ", "ベ": "ﾍﾞ", "ボ": "ﾎﾞ",
        "パ": "ﾊﾟ", "ピ": "ﾋﾟ", "プ": "ﾌﾟ", "ペ": "ﾍﾟ", "ポ": "ﾎﾟ",
        "ヴ": "ｳﾞ", "ヷ": "ﾜﾞ", "ヺ": "ｦﾞ",
        "ア": "ｱ", "イ": "ｲ", "ウ": "ｳ", "エ": "ｴ", "オ": "ｵ",
        "カ": "ｶ", "キ": "ｷ", "ク": "ｸ", "ケ": "ｹ", "コ": "ｺ",
        "サ": "ｻ", "シ": "ｼ", "ス": "ｽ", "セ": "ｾ", "ソ": "ｿ",
        "タ": "ﾀ", "チ": "ﾁ", "ツ": "ﾂ", "テ": "ﾃ", "ト": "ﾄ",
        "ナ": "ﾅ", "ニ": "ﾆ", "ヌ": "ﾇ", "ネ": "ﾈ", "ノ": "ﾉ",
        "ハ": "ﾊ", "ヒ": "ﾋ", "フ": "ﾌ", "ヘ": "ﾍ", "ホ": "ﾎ",
        "マ": "ﾏ", "ミ": "ﾐ", "ム": "ﾑ", "メ": "ﾒ", "モ": "ﾓ",
        "ヤ": "ﾔ", "ユ": "ﾕ", "ヨ": "ﾖ",
        "ラ": "ﾗ", "リ": "ﾘ", "ル": "ﾙ", "レ": "ﾚ", "ロ": "ﾛ",
        "ワ": "ﾜ", "ヲ": "ｦ", "ン": "ﾝ",
        "ァ": "ｧ", "ィ": "ｨ", "ゥ": "ｩ", "ェ": "ｪ", "ォ": "ｫ",
        "ッ": "ｯ", "ャ": "ｬ", "ュ": "ｭ", "ョ": "ｮ",

        "。": "｡", "、": "､", "ー": "ｰ", "「": "｢", "」": "｣", "・": "･"

    }

    var reg = new RegExp('(' + Object.keys(kanaMap).join('|') + ')', 'g');



    var NewText = text.replace(reg, function (match) {
        return kanaMap[match];
    })
        .replace(/゛/g, 'ﾞ')
        .replace(/゜/g, 'ﾟ');

    if (OldText == NewText) {
        var NewText = text.replace(/[Ａ-Ｚａ-ｚ０-９]/g, function (s) {
            return String.fromCharCode(s.charCodeAt(0) - 0xFEE0);
        });
    }


    console.log("NewText");
    console.log(NewText);

    return NewText;

}
//------------------------------------------------------------------------------------


var CurrentURL;
//ブラウザバック制御------------------------------------------------------------------

function IfURL(CurrentUrl , phaseNo) {
    CurrentURL = CurrentUrl;
    if (BackButton == true) {

        return PhaseNo;
    } else {
        return phaseNo;
    }
    ;

}

var PhaseNo;
function PhaseNo(Phaseno) {
    PhaseNo = Phaseno;
}

var BackButton;


history.replaceState(null, document.getElementsByTagName('title')[0].innerHTML, null);
window.addEventListener('popstate',function (e) {


    alert('ブラウザバックを検知しました。');
    //DotNet.invokeMethod('B2003C4', 'ReturnShift');

    /*
    if (CurrentURL == "Kansa/KansaParent") {
        BackButton = true;
        PhaseNo--;
    }

    history.pushState(null, null, /Kansa/KansaParent);
    return;
    */
});
function CallFuncBlazor() {
    DotNet.invokeMethod('Kansa', 'JSFunc')
}
window.WriteCSharpMessageToConsole = (dotnetHelper) => {
    dotnetHelper.invokeMethodAsync('GetHelloMessage')
        .then(message => console.log(message));
}
