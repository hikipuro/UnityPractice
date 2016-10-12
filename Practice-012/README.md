# Practice 012

外部 DLL と連携する

## 使い方

- Unity を起動
- UnityPractice/Practice-012 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- コンソールビュー内に、外部 DLL 呼び出しの結果が表示される

## 説明

外部 DLL についての詳しい説明
- C#スクリプトをDLL化してUnityで使う - Qiita
  http://qiita.com/r-ngtm/items/50afdb29c671001bb290

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- GameObject を 1 個設置 (GameObject - Create Empty)
  - インスペクタビューを開く
  - 名前を Scripts に変更
  - DLLTest をドラッグする

## コードの内容

Assets/DLLTest.cs

- 外部 DLL の名前空間への参照を追加する
  - using Practice012.DLL; を上の方に書いておく
  - Assets/Plugins フォルダに DLL を配置しておくと、自動的に使えるようになるらしい
  - using の行でエラーが出る場合は、参照の設定を追加する必要があるかも

DLL/Practice012DLL.cs

- Visual Studio 単体で DLL/DLL.sln を開いてから編集する
  - Unity 経由で開かないようにする
- プロジェクトの設定をしてからビルドする
  - 対象のフレームワーク: .NET Framework 2.0
  - .NET 2.0 で出力されていないと、 Unity 側で呼び出し時にエラーが出る
- ビルドできたら、出力されたファイルを Unity 内に移動する
  - DLL/bin/(Debug or Release)/DLL.dll を Assets/Plugins に移動

## 実行環境

- Unity 5.3.5f1
- Visual Studio 2013 (Community)

## 作者

- hikipuro
