/// <summary>
/// プロジェクトの設定で、次の設定をしてからビルドする。
/// 対象のフレームワーク: .NET Framework 2.0
/// 
/// Unity 内から使う場合は、
/// using Practice012.DLL;
/// を書いておく。
/// 
/// 参考 URL :
/// C#スクリプトをDLL化してUnityで使う - Qiita
/// http://qiita.com/r-ngtm/items/50afdb29c671001bb290
/// </summary>
namespace Practice012.DLL {
    public class Practice012DLL {
		/// <summary>
		/// 足し算.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static int Add(int a, int b) {
			return a + b;
		}

		/// <summary>
		/// 掛け算.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static int Mul(int a, int b) {
			return a * b;
		}
    }
}
