# Practice 003

クリックした位置にゲームオブジェクトを移動させる

![Practice 003](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-003.png)

## 使い方

- Unity を起動
- UnityPractice/Practice-003 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 画面内をクリックすると、クリックした位置に立方体が移動する

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Plane を 1 個設置 (GameObject - 3D Object - Plane)
- Cube を 1 個設置 (GameObject - 3D Object - Cube)
- カメラとライトの位置と角度を調整
- Cube のインスペクタビュー内に Move をドラッグする

## コードの内容

Assets/Move.cs

- Update() メソッドにコードを書くと、毎フレーム処理が実行される
- Input.GetMouseButtonDown(0) の戻り値を使って、左クリックされた瞬間を判定
  - 引数に 1 を入れると、右クリックの判定ができる
- Physics.Raycast() メソッドで、カメラの位置からマウス座標の方向へ視線を飛ばす
- 視線が何かに当たったら、視線の当たった位置へ立方体を移動させる

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
