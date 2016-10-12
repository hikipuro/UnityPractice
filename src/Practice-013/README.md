# Practice 013

シェーダーでテクスチャを作成する

![Practice 013](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-013.png)

シェーダーとは:
- オブジェクトの色を塗るためのプログラム
- Unity では HLSL という言語で書く
- シェーダーのプログラムは GPU 内で実行されるため、CPU 負荷はかからない

## 使い方

- Unity を起動
- プロジェクトビュー内で Main をダブルクリック

## 説明

Practice-004 とほぼ同じ実行結果になります。
004 では C# で色を塗っていましたが、今回はシェーダーを使って色を塗っています。

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Quad を 1 個設置 (GameObject - 3D Object - Quad)
  - インスペクタビューを開く
  - マテリアルを変更する (Materials - Element 0 にプロジェクトビューから Quad をドラッグする)
  - シェーダーの設定を Custom/TestShader に変更する

## コードの内容

Assets/TestShader.shader

- HLSL で書く必要があるため、 C# とは書き方が異なる
- surf() メソッドで色を塗っていく
  - 1 ピクセルごとにメソッドが呼び出される想定で書く (GPU 内で並列に実行される)
  - 引数の IN で入力されるテクスチャ、座標等を取得する
  - 引数の o に値を設定することで、色が決定される

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
