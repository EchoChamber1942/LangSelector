using Oxide.Core.Libraries.Covalence;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Oxide.Plugins
{
    [Info("LangSelector", "EchoChamber", "1.0.0")]
    [Description("Simple language switcher. Players change their plugin language with /ls <code>. / シンプルな言語切り替え。プレイヤーが /ls <code> でプラグインの言語を変更可能。")]
    public class LangSelector : CovalencePlugin
    {
        // Registered ISO-639-1 language codes and native names / 登録済ISO-639-1 言語コードとネイティブ名
        private static readonly Dictionary<string, string> LanguageTable = new()
        {
            ["en"] = "English",
            ["ja"] = "日本語",
            ["ko"] = "한국어",
            ["zh"] = "中文",
            ["fr"] = "Français",
            ["de"] = "Deutsch",
            ["es"] = "Español",
            ["pt"] = "Português",
            ["ru"] = "Русский",
            ["tr"] = "Türkçe",
            ["it"] = "Italiano",
            ["nl"] = "Nederlands",
            ["pl"] = "Polski",
            ["sv"] = "Svenska",
            ["no"] = "Norsk",
            ["da"] = "Dansk",
            ["fi"] = "Suomi",
            ["cs"] = "Čeština",
            ["sk"] = "Slovenčina",
            ["ro"] = "Română",
            ["hu"] = "Magyar",
            ["uk"] = "Українська",
            ["th"] = "ไทย",
            ["vi"] = "Tiếng Việt",
            ["id"] = "Bahasa Indonesia",
            ["ms"] = "Bahasa Melayu",
            ["hi"] = "हिन्दी",
            ["bn"] = "বাংলা",
            ["ta"] = "தமிழ்",
            ["ml"] = "മലയാളം",
            ["te"] = "తెలుగు",
            ["fa"] = "فارسی",
                   ["he"] = "עברית",
                   ["ar"] = "العربية",
                   ["sr"] = "Српски",
            ["hr"] = "Hrvatski",
            ["el"] = "Ελληνικά"
        };

        private void Init()
        {
            // Register messages for each language / 各言語メッセージを一括登録
            foreach (var (code, nativeName) in LanguageTable)
            {
                lang.RegisterMessages(new Dictionary<string, string>
                {
                    ["LanguageName"] = nativeName,
                    ["LangSwitched"] = "Language switched to: {0}"
                }, this, code);
            }
        }

        private static string GetLangDisplayName(string code)
        {
            // Return in [EN] English format / [EN] English形式で返す
            string label = code.Length == 2 ? code.ToUpper() : code;
            string native = LanguageTable.TryGetValue(code, out var n) ? n : code;
            return $"[{label}] {native}";
        }

        [Command("ls")]
        private void CmdSetLang(IPlayer player, string command, string[] args)
        {
            if (args.Length == 0)
            {
                // No args: display current language / 引数なし：現在の言語を表示
                string currentCode = lang.GetLanguage(player.Id);
                player.Reply($"Current language: {GetLangDisplayName(currentCode)}");
                return;
            }

            // With language code: switch language / 言語コード指定時：切替処理
            string targetCode = args[0].ToLowerInvariant();
            if (!LanguageTable.ContainsKey(targetCode))
            {
                player.Reply($"Invalid language code: {targetCode}");
                return;
            }

            lang.SetLanguage(targetCode, player.Id);
            player.Reply($"Language switched to: {GetLangDisplayName(targetCode)}");
        }
    }
}
