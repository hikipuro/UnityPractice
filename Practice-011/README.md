# Practice 011

コードでメッシュを変形する

![Practice 011](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-011.png)

## 使い方

- Unity を起動
- UnityPractice/Practice-011 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- メッシュが波打つ

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Plane を 1 個設置 (GameObject - 3D Object - Plane)
  - インスペクタビューを開く
  - MoveVertex をドラッグする

## コードの内容

Assets/MoveVertex.cs

- Start() メソッドで、開始時に Mesh オブジェクトを取得する
- Update() メソッドで、毎フレーム頂点を移動させる

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
