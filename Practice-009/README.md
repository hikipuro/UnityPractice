# Practice 009

コードでメッシュを作成する

メッシュとは:
- 立体的に配置された三角形の集まり (座標の列)
- 三角形の集まりにすると、Unity 上で立体的に表示することができる

## 使い方

- Unity を起動
- UnityPractice/Practice-009 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 画面に五角形が表示される

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- GameObject を 1 個設置 (GameObject - Create Empty)
  - インスペクタビューを開く
  - オブジェクトの名前を Mesh に変更する
  - Add Component ボタンを押して、 Mesh - Mesh Filter を追加
  - 同様に、 Mesh - Mesh Renderer を追加
  - Mesh Renderer の Materials - Element 0 に Default-Material を設定
  - プロジェクトビューから MeshCreator をドラッグする

## コードの内容

Assets/MeshCreator.cs

- CreatePolygon() メソッドで、平面の多角形を作成する
  - メッシュオブジェクトには、次の要素をセットする
    - 頂点の座標の列 (vertices)
    - 頂点同士を繋ぐ、三角形のインデックスの列 (triangles)
- Start() メソッドの中で多角形を作成し、 MeshFilter に適用する
  - Start() に書いた処理は、開始時に一度だけ実行される

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
