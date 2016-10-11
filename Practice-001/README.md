# Practice 001

ゲームオブジェクトの色を変える

## 使い方

- Unity を起動
- UnityPractice/Practice-001 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 画面内の立方体にマウスを乗せると色が変わる
- 立方体の外にマウスを移動させると元の色に戻る

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Cube を 1 個設置 (GameObject - 3D Object - Cube)
- カメラとライトの位置と角度を調整
- Cube のインスペクタビュー内に ChangeColor をドラッグする

## コードの内容

Assets/ChangeColor.cs

- 拡張子 .cs のファイルは C# で書かれたコード
- Unity は C# か JavaScript でコードを書くことができる
- OnMouseEnter() メソッドにコードを書くと、マウスが乗った時の処理を追加できる
- OnMouseExit() メソッドにコードを書くと、マウスが外に出た時の処理を追加できる
- print() メソッドでコンソールビューにログを表示できる (デバッグに使用する)
- ゲームオブジェクトの色を変える時は、 Material オブジェクト経由で色を変える

## 実行環境

- Unity 5.3.5f1
