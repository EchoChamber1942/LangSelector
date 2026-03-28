# LangSelector

**Bilingual README / 英和README**

LangSelector is a lightweight command-based language switcher that lets each player instantly change the language used by every uMod plugin that supports Oxide’s lang system.  
LangSelector は、Oxide の lang システムに対応したすべての uMod プラグインの表示言語を、各プレイヤーがチャットコマンドで即座に切り替えられる軽量な言語スイッチャーです。

> **Note / 補足**  
> This plugin is designed to be simple, lightweight, and dependency-free.  
> このプラグインは、シンプル・軽量・依存関係なしを前提に設計されています。

---

## Overview / 概要

### English
**Main purposes:**
- Let players switch plugin language with a simple command
- Support multiple preset language codes
- Save each player's selected language
- Restore the language after reconnect
- Work with Oxide lang-based plugins without extra dependencies

### 日本語
**主な用途:**
- シンプルなコマンドでプラグイン表示言語を切り替え
- 複数の言語コードプリセットに対応
- プレイヤーごとの選択言語を保存
- 再ログイン後も設定を維持
- Oxide の lang ベース多言語プラグインと追加依存なしで併用可能

---

## Features / 機能

### English
- One-line switching with `/ls <code>`
- 40 ISO-639-1 preset language codes
- `/ls` with no arguments shows the current language
- Per-player persistence
- Zero external dependencies

### 日本語
- `/ls <コード>` で1行切り替え
- ISO-639-1 ベースの 40 言語プリセット
- 引数なしの `/ls` で現在言語を表示
- プレイヤーごとに保存
- 外部依存なし

---

## Permissions / 権限

### English
No permissions are required. Every player can use `/ls`.

If you want to restrict usage, wrap the command using a separate permission or command-control plugin.

### 日本語
特別な権限は不要です。すべてのプレイヤーが `/ls` を使用できます。

使用制限をかけたい場合は、別の権限制御プラグインやコマンド制御プラグインでラップしてください。

---

## Chat Commands / チャットコマンド

| Command | English | 日本語 |
|---|---|---|
| `/ls` | Shows the current language | 現在の言語を表示 |
| `/ls <code>` | Changes the language | 言語を変更 |

### Examples / 例

```txt
/ls
/ls ja
/ls en
```

**EN:** Example output: `Current language: [EN] English`  
**JP:** 表示例: `Current language: [JA] 日本語`

---

## Installation / インストール

### English
1. Place `LangSelector.cs` in the `oxide/plugins` folder  
2. Reload the plugin or restart the server

```txt
oxide.reload LangSelector
```

### 日本語
1. `LangSelector.cs` を `oxide/plugins` フォルダへ配置  
2. プラグインをリロードするか、サーバーを再起動

```txt
oxide.reload LangSelector
```

---

## Configuration / 設定

### English
This plugin is designed to work without external configuration files for basic use.

Language presets are stored directly inside the plugin source in `LanguageTable`.

Example structure:
```csharp
private readonly Dictionary<string, string> LanguageTable = new()
{
    ["en"] = "English",
    ["ja"] = "日本語"
};
```

### 日本語
このプラグインは、基本利用において外部設定ファイルなしで動作するよう設計されています。

言語プリセットは、プラグイン内部の `LanguageTable` に直接定義されています。

構造例:
```csharp
private readonly Dictionary<string, string> LanguageTable = new()
{
    ["en"] = "English",
    ["ja"] = "日本語"
};
```

---

## Adding New Languages / 新しい言語の追加

### English
Add a new line to `LanguageTable`, such as:

```csharp
["es"] = "Español",
```

No further code changes are required.

### 日本語
`LanguageTable` に次のような1行を追加します。

```csharp
["es"] = "Español",
```

それ以外のコード変更は基本的に不要です。

---

## Compatibility / Dependencies  
## 互換性 / 依存関係

### English
LangSelector uses only Oxide’s built-in lang API and has no other dependencies.

It can be used together with any plugin that uses `lang.GetMessage()`.

### 日本語
LangSelector は Oxide 標準の lang API のみを使用し、他の依存関係はありません。

`lang.GetMessage()` を利用している多言語対応プラグインとそのまま併用できます。

---

## Data / 保存仕様

### English
- The selected language is saved per player
- The setting persists after reconnect
- No external library is required for persistence support

### 日本語
- 選択した言語はプレイヤーごとに保存されます
- 再ログイン後も設定は維持されます
- 保存機能のために外部ライブラリは不要です

---

## Credits / クレジット

### English
Original author: `YourNameHere`  
Feedback and pull requests are welcome.

### 日本語
作者: `EchoChamber`  
不具合報告やプルリクエストを歓迎します。

---

## Changelog / 更新履歴

| Version | Date | English | 日本語 |
|---|---|---|---|
| 1.0.0 | 2025-06-22 | Initial release | 初版リリース |

---

## Summary / まとめ

**EN:** LangSelector is a simple and lightweight per-player language switcher for Oxide/uMod plugins that support the lang system.  
**JP:** LangSelector は、Oxide/uMod の lang システム対応プラグイン向けに、プレイヤー単位で表示言語を切り替えられるシンプルかつ軽量な言語スイッチャーです。
