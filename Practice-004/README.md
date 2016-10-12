# Practice 004

コードでテクスチャを作成する

![Practice 004](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-004.png)

## 使い方

- Unity を起動
- UnityPractice/Practice-004 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 画面中央の平面の色が変わる

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Quad を 1 個設置 (GameObject - 3D Object - Quad)
- Quad のインスペクタビュー内に CodeTexture をドラッグする

## コードの内容

Assets/CodeTexture.cs

- Start() メソッドにコードを書くと、開始時に一度だけ実行される
- Texture2D 型のオブジェクトを作成して、その中にピクセル列をセットする
- 作成したテクスチャをマテリアルにセットする

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
