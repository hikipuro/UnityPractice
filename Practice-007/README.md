# Practice 007

ビルボードを表示する

![Practice 007](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-007.png)

ビルボードとは:
- カメラに向かって、常に正面を向くオブジェクト

## 使い方

- Unity を起動
- UnityPractice/Practice-007 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 十字キーでカメラを移動する
  - 青いオブジェクトのみ、常にカメラの正面を向くように設定している

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Plane を 1 個設置 (GameObject - 3D Object - Plane)
- Quad を 2 個設置 (GameObject - 3D Object - Quad)
- プロジェクトビューでマテリアルを 2 個作成する
  - それぞれを Quad に適用し、個別の色を設定する
- Quad のどちらか 1 つに、インスペクタビュー内で Billboard をドラッグする
- Main Camera のインスペクタビュー内に MoveCamera をドラッグする

## コードの内容

Assets/MoveCamera.cs

- 十字キーでカメラを移動する

Assets/Billboard.cs

- パブリックメンバ変数として camera を設定
- パブリックメンバは、インスペクタビューで値を設定できる
- Start() メソッドで、 camera が未設定の時の処理を追加
  - メインカメラを設定しておく
- Update() メソッドに、毎フレームカメラの方向を向く処理を追加


## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
