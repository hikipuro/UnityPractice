# Practice 014

テキストリソースを実行時にロードする

![Practice 014](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-014.png)

## 使い方

- Unity を起動
- プロジェクトビュー内で Main をダブルクリック
- 画面内のテキストの内容が変更される

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Canvas を 1 個設置 (GameObject - UI - Canvas)
  - ヒエラルキービューで Canvas を選択状態にする
- Text を 1 個設置 (GameObject - UI - Text)
  - Text の位置を調整する
- GameObject を 1 個設置 (GameObject - Create Empty)
  - インスペクタビューを開く
  - 名前を Scripts に変更
  - LoadText をドラッグする
  - Load Text (Script) の Target Text のところに、ヒエラルキービューの Canvas/Text をドラッグする

## コードの内容

Assets/LoadText.cs

- targetText という変数をパブリック属性で作っておく
  - パブリック属性で作った変数の内容は、インスペクタビューで変更できるようになる
- Start() の中で、テキストリソースをロードする
  - Resources.Load() で、リソースをロードする
  - Load<ロードするリソースの型名>(); という書き方で書く
  - Assets 内の、 Resources フォルダの中に入ったファイルのみロードできる (階層はどこでも OK)

## 実行環境

- Unity 5.4.2f1

## 作者

- hikipuro
