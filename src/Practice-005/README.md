# Practice 005

十字キーでカメラを移動させる

![Practice 005](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-005.png)

## 使い方

- Unity を起動
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 十字キーの操作でカメラが移動する

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Plane を 1 個設置 (GameObject - 3D Object - Plane)
- GameObject を 1 個設置 (GameObject - Create Empty)
- GameObject 内に Cube を 2 個設置 (GameObject - 3D Object - Cube)
- Cube が 2 個入った GameObject をコピーして移動させる (3 回繰り返す)
- カメラとライトの位置と角度を調整
- Main Camera のインスペクタビュー内に MoveCamera をドラッグする

## コードの内容

Assets/MoveCamera.cs

- Update() メソッドにコードを書くと、毎フレーム処理が実行される
- Input.GetKey() メソッドで、キー入力の判定ができる
- transform.position で位置を変える
- transform.forward は、オブジェクトの前の方向を指す
  - transform.right, transform.up もある
  - -1 を掛けると逆の方向になる

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
