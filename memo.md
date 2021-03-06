# WPFでアプリを作ってみる
デスクトップアプリの練習。

## 要件
- 画面からレポートを登録できる。レポートは更新が可能。
- 無線LAN内の複数PCでデータを共有して使用可能。（共有フォルダ設定を行う）
- 登録したレポートの内容でテキストファイルを作成する。
- 画面ごとにプロジェクトを分けて独立させる。
- インストーラをつける。
- アップデート機能をつける。

### 実行環境
||| 
|:--|:--|
|OS|Windows7以上|
|ネット環境|無線LANがあったりなかったり。外部へはメールのみ(100M以下)。|
|||

### 開発環境
||| 
|:--|:--|
|言語|C#|
|フレームワーク|.Net FrameWork 3.5|
|||

## 今回使うライブラリとか
- WPF
- SQLite3

## プロジェクト構成
|プロジェクト|種別|役割| 
|:--|:--|:--|
|Main|exe|アプリの起動。画面遷移。config読み込み。|
|FormCommon|dll|フォーム画面の共通部品。>データアクセス層ベース。|
|ReportFormCommon|dll|Reportプロジェクトの共通部品|
|ReportFormXX|dll|各レポートの画面、データ定義、DB入出力、ファイル作成|
||||

## やること一覧
1. WPF勉強する

    - [GUIプログラミング入門](https://qiita.com/Kosen-amai/items/f9e3df2aa80363f5af5b)  
        一通りやればものになりそう

|Q|A|
|:--|:--|
|画面遷移のスマートな方法は？|[NavigationWindowを使った画面遷移](http://sourcechord.hatenablog.com/entry/20130831/1377942291)  / [[WPF][MVVM] コードビハインドは汚さずにボタンでページ遷移する3つの方法](https://note.mu/codeone/n/nb862e069f5e1)|
|ViewModelの使い方|[【WPF覚書】ViewModelとデータバインディング](https://qiita.com/TAK_EMI/items/ba85ce1e0b65f57364ad)/[WPF4.5入門 その56「コレクションのバインディング」](https://blog.okazuki.jp/entry/2014/10/29/220236)|
|クラスライブラリにページ置きたい|[【VB.NET】【WPF】クラスライブラリ（DLL）に WPF ウィンドウを追加する](https://elleneast.com/?p=8464#_WPF-2)/[wpf - 'InitializeComponent'という名前は現在のコンテキストには存在しません](http://jp.itasr.com/qa/details/2110249013411841024)/[WPFのWindowをDLLし共有したい](https://social.msdn.microsoft.com/Forums/ja-JP/c376d046-6169-4b34-865d-46abacc6d7f3/wpfwindowdll?forum=wpfja)|
|クラスライブラリのページに遷移したい|[【WPF】別アセンブリからリソースを読み込む。](http://pro.art55.jp/?eid=1176521)/[Navigation Frameworkで、別アセンブリにあるページに遷移するときのURIの書き方](https://blog.okazuki.jp/entry/20100216/1266295413)|
|CSSみたいに外部ファイルにスタイルを定義したい|[【WPF】スタイルをCSSみたいに外部ファイルに定義する](https://www.doraxdora.com/blog/2017/06/08/post-1155/)|
|レイアウトの作り方|[WPF4.5入門 その15 「レイアウトコントロールのDockPanelとWrapPanel」](https://blog.okazuki.jp/entry/20130105/1357395569)|
|OSSのツールキット|[SilverlightToolkit](https://github.com/microsoftarchive/SilverlightToolkit)/[WPFToolkit](https://archive.codeplex.com/?p=wpf)/[Windows GUIプログラミング入門20 NuGet(2), コントロール集](https://qiita.com/Kosen-amai/items/c5cecf81240407693cda)|
|MVVMが難しいよ！|[MVVM入門 その１「シンプル四則演算アプリケーションの作成」](https://code.msdn.microsoft.com/windowsdesktop/MVVM-d8261534)/[PrismとReactivePropertyで簡単MVVM！](https://qiita.com/hiki_neet_p/items/e381c687b0644c0e4978)/[MVVM フレームワーク Prism の全体概観](https://qiita.com/toydev/items/cf1bb4b519e7e2453d46)|
|xaml内で文字列の加工とかしたい|[WPFのStringFormatによるフォーマット指定](http://nineworks2.blog.fc2.com/blog-entry-10.html)|
|バリデーションチェックしたいけどIDataErrorInfoしか使えないよ|[IDataErrorInfoとValidation.ErrorTemplateを利用してエラーを表示する](https://www.pine4.net/Memo/Article/Archives/427)/[WPFでの入力値検証](http://sourcechord.hatenablog.com/entry/2014/05/11/202656)/[方法 : バインディングの検証の実装](https://docs.microsoft.com/ja-jp/dotnet/framework/wpf/data/how-to-implement-binding-validation)|
|ViewModelはどうやってビジネスロジックとお話しするの|[コマンドをバインディングする](http://marikooota.hatenablog.com/entry/2017/05/30/234258)|

2. 画面遷移機能を作る  
 
- 依存関係はexeにまとめる
    Commonはdllとexe両方から参照しないとエラーになったよ
- クラスライブラリ作るときはframefork3.5, ユーザコントロールライブラリ

3. フォーム画面を1個作る 

- レイアウト共通化

    [WPF4.5入門 その50 「Style」](https://blog.okazuki.jp/entry/2014/09/04/200304)

- 共通コントロールの依存関係はどうなるのっと

4. SQLite勉強する
5. レポート登録機能作る
6. レポート更新機能作る
7. ファイル作成機能作る
8. データ共有機能作る
