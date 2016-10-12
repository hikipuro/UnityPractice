# Practice 008

プレハブをコピーする

![Practice 008](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-008.png)

プレハブとは:
- オブジェクトを再利用するためのテンプレート

## 使い方

- Unity を起動
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 1 秒ごとに、オブジェクトがコピーされる

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Quad を 1 個設置 (GameObject - 3D Object - Quad)
- プロジェクトビューでマテリアルを 1 個作成する
  - Quad に適用する
    - インスペクタビューを開く
    - Mesh Renderer - Materials - Element 0 にマテリアルをドラッグする
  - テクスチャを適用する
    - インスペクタビューのテクスチャの設定画面を開く (インスペクタビューの一番下)
    - Albedo の左の四角の中に、プロジェクトビューから画像をドラッグする
    - Tiling, Offset を設定して、画像の表示位置を調整する
- Quad をヒエラルキービューからプロジェクトビューにドラッグして、プレハブを作成する
  - ヒエラルキービューからプロジェクトビューにドラッグする操作で、自動的にプレハブになる
- GameObject を 1 個設置 (GameObject - Create Empty)
  - 名前を Scripts に設定する
- GameObject に、 CopyPrefab をドラッグする
  - インスペクタビューを開く
  - Copy Prefab (Script) の、 Base Prefab のところに、プロジェクトビューから Quad のプレハブをドラッグする
    (ヒエラルキービューからドラッグしても入ってしまうので注意)

## コードの内容

Assets/CopyPrefab.cs

- public メンバとして BasePrefab を追加
  - public メンバとして追加すると、インスペクタビューで調整できるようになる
- count 変数でフレーム数をカウントする
- Update() メソッド内で、
  - count 変数を使って 60 フレームをカウントする
  - 60 フレーム経過後、プレハブをコピーする
  - コピーしたプレハブの位置を調整する

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro

## 画像素材について

ぴぽやさんからお借りしました。ありがとうございます！

http://piposozai.wiki.fc2.com/
