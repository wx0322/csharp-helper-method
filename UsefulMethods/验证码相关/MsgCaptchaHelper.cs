using System.Text;

namespace 验证码相关 {

  /// <summary>
  /// 短信验证码帮助类
  /// </summary>
  public class MsgCaptchaHelper {

    /// <summary>
    /// 生成指定位数的随机数字码
    /// </summary>
    /// <param name="aLength"></param>
    /// <returns></returns>
    public static string CreateRandomNumber(int aLength) {
      Random bRandom = new Random();
      StringBuilder bSBMsgCode = new StringBuilder();
      for (int i = 0; i < aLength; i++) {
        bSBMsgCode.Append(bRandom.Next(0, 9));
      }

      return bSBMsgCode.ToString();
    }
  }
}
