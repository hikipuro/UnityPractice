# Practice 010

重力でボールを動かす

![Practice 010](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-010.png)

## 使い方

- Unity を起動
- UnityPractice/Practice-010 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- ボールが転がる

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Sphere を 1 個設置 (GameObject - 3D Object - Sphere)
  - インスペクタビューを開く
  - オブジェクトの名前を Ball に変更する
  - Add Component ボタンを押して、 Physics - Rigidbody を追加
  - プロジェクトビュー内で Create - Physic Material を追加
    - Physic Material の Bounciness を設定
  - Physic Material を Sphere にドラッグ
- 適当に床と壁を作成する

## コードの内容

- 今回はコードなし

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
