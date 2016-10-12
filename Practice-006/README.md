# Practice 006

GUIでボタンを表示する

![Practice 006](https://raw.githubusercontent.com/hikipuro/UnityPractice/image/image/screenshot/Practice-006.png)

## 使い方

- Unity を起動
- UnityPractice/Practice-006 フォルダを開く
- プロジェクトビュー内で Main をダブルクリック
- 再生ボタンをクリック
- 画面中央のボタンを押すと、ボタンのラベルが変更される

## 説明

Main シーンと同じ状態を作るには:

- Unity で新規シーンを作成 (File - New Scene)
- Canvas を 1 個設置 (GameObject - UI - Canvas)
  - Canvas を追加すると、自動的に EventSystem も追加される
- Canvas 内に Button を 1 個設置 (GameObject - UI - Button)
- Button のインスペクタビュー内で次の操作をする
  - サイズを調整する
  - ButtonTest をドラッグする
  - Button (Script) のところで、 On Click () の右下の＋ボタンを押す
  - "Runtime Only" のすぐ下に、ヒエラルキービューから Button をドラッグする
  - "No Function" のところをクリックして、 ButtonTest - OnClickButton () を選択する

## コードの内容

Assets/ButtonTest.cs

- UI 要素を扱う時は、 using UnityEngine.UI; を書いておく
- public 属性で OnClickButton() メソッドを作成
- GetComponentInChildren() メソッドで、子要素の中から指定された型のオブジェクトを探す
- Text.text に文字列をセットすると、表示内容が変更される

## 実行環境

- Unity 5.3.5f1

## 作者

- hikipuro
