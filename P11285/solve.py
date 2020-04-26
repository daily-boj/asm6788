choseong_Tbl  = "ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎ"
jungseong_Tbl = "ㅏㅐㅑㅒㅓㅔㅕㅖㅗㅘㅙㅚㅛㅜㅝㅞㅟㅠㅡㅢㅣ"
jongseong_Tbl = " ㄱㄲㄳㄴㄵㄶㄷㄹㄺㄻㄼㄽㄾㄿㅀㅁㅂㅄㅅㅆㅇㅈㅊㅋㅌㅍㅎ"

while True:
    cho = input();
    jung = input();
    jong = input();

print(chr(0xAC00 + (choseong_Tbl.find(cho) * 21 + jungseong_Tbl.find(jung)) * 28 + jongseong_Tbl.find(jong)))
