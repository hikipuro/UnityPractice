# Practice 002

カメラをその場で回転させる

## 使い方

- Unity を起動
- UnityPractice/Practice-002 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- カメラがその場で回転する

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Plane を 1 個設置 (GameObject - 3D Object - Plane)
- GameObject を 1 個設置 (GameObject - Create Empty)
- GameObject 内に Cube を 2 個設置 (GameObject - 3D Object - Cube)
- Cube が 2 個入った GameObject をコピーして回転させる (3 回繰り返す)
- カメラとライトの位置と角度を調整
- Main Camera のインスペクタビュー内に RotateCamera をドラッグする

## コードの内容

Assets/RotateCamera.cs

- Update() メソッドにコードを書くと、毎フレーム処理が実行される
- transform.Rotate() メソッドで、ゲームオブジェクトを回転させる

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
