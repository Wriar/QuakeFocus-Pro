# 初期リリースの開発者の皆様へ - ATTENTION BETA TESTERS

### [VIEW ADVANCED SETUP GUIDE HERE! ](https://quakefocusdev.gitbook.io/quakefocus-pro/)
You should have received an email that contains a PDF file detailing the operation of this service. If you
encounter any issues, please consult that guide before creating a new issue.

**IF YOU DID NOT RECEIVE THE PDF FILE, READ THE ``setupguide.md`` file!**


**UPDATE:** Please only download code or packages from the MAIN branch. Code or packages from the unstable/development branch may not function properly and are not formatted for use.

If there is a translation issue, please create a new issue in the "ISSUES" tab and mark it with the "translation"
tag. 

If there is a code issue, please create a new issue in the "ISSUES" tab and mark it with the "code-issue" tag.

If you would like to contribute, please create a new pull request and provide a summary with the changes given.

## Resolving Issues

Errors/Warnings will be logged inside the logs folder stored within the application path. Please upload the full logs as they contain detailed information.
Please do not modify or alter any of the assets stored in the "/assets" folder, as the contain important strong-motion calibration and storage data on NIED
sensor points. 

Specific issues will have specific termination errors, such as the following:

| ISSUE TYPE | Action Needed | Explanation |
|------------|---------------|-------------|
| Code | **Create a new issue** if this error is not already reported | A fatal error has occured within the application's code. |
| Service | Check your internet connection or proxy connection | Application cannot the external API to retrieve information |
| Info | No Action | Important debugging messages that are written to the logfile, such as successfully retrieving information. |

Specific fatal errors, such as code errors, will force the application to shutdown to prevent future errors. It is very important
to **create a new issue** to let developers know about the bug. 

**Unknown Other Warnings:** This application uses dependencies from other projects whom handle their own errors. If you don't see an error pane that looks like it was generated and handled by QuakeFocus Pro, please create an issue. The default error pane is attached within the PDF or setupguide.md file you received. Please note that such related issues may not be resolved immediately as cooperation and collaboration between two service providers will be needed before the error is resolved. 

## Currently Known Issues

Some users have reported extreme and unreasonable allocation of memory greater then 200MB. This issue is due to a tuple list not erasing whilst reading a JSON pack due to an incorrectly updated variable. A fix is currently being implemented and will be resolved shortly.

## 初期リリースのテスター用

本サービスの操作方法を記載したPDFファイルを添付したメールが届いているはずです。もしも
問題が発生した場合は、新しい問題を作成する前にガイドを参照してください。

**PDFファイルを受け取っていない場合は、``setupguide.md``ファイルを読んでください！***。

翻訳に関する問題が発生した場合は、「ISSUES」タブで新しい課題を作成し、「translation」タグを付けてください。
タグを付けてください。

コードに関する問題がある場合は、"ISSUES "タブで新しい問題を作成し、"code-issue "タグを付けてください。

貢献したい場合は、新しいプルリクエストを作成し、与えられた変更点を含む概要を提供してください。

##問題の解決

エラーや警告は、アプリケーションのパスに含まれるlogsフォルダに記録されます。詳細な情報が含まれていますので、完全なログをアップロードしてください。
ASSETS "フォルダに保存されているアセットは、NIEDのセンサーポイントの重要な強震キャリブレーションとストレージデータが含まれていますので、変更しないでください。
センサーポイントの重要な強震キャリブレーションと保存データが含まれているからです。

特定の問題には、以下のような特定の終了エラーがあります。

| 課題タイプ | 必要なアクション | エラーの原因 |
|-----------|-----------------|-------------|
| CODE/コード |新しいGitHubの課題を作成します。 |致命的なアプリケーションエラー
| SERVICE/サービス | インターネット接続やプロキシ接続の確認 | アプリケーションが外部APIで情報を取得できない
| INFO/情報 | ノーアクション | 情報の取得に成功した場合など、ログファイルに書き込まれる重要なデバッグメッセージ。


コードエラーなどの特定の致命的なエラーが発生した場合、今後のエラーを防ぐためにアプリケーションを強制的にシャットダウンします。非常に重要です。
開発者にバグを知らせるために**新しい課題を作成**することが非常に重要です。

## 現在判明している問題
一部のユーザーから、200MBを超えるメモリの極端で不合理な割り当てが報告されました。この問題は、誤って更新された変数のために、JSONパックの読み取り中にタプルリストが消去されないことが原因です。現在、修正プログラムを実施しており、まもなく解決する予定です。

# QuakeFocus-Pro
QuakeFocus strong-motion monitoring application and issue tracking

> This project is not yet completed, this text will be removed once the finished product has been uploaded.

## About:
This application is written in a BASIC language so others can read and develop off this framework. It is easily converted to ``C#`` projects and is developed under the ``.NET`` environment for Windows PCs. It can send and receive webhooks and is very customizable. There is a development ``C#`` repository, however, that is private. 

User configuration files can be edited in a text editor or editing within the application setting pane itself. 


## Project Roadmap:

| Feature | Date Created | Date Completed |
|---------|--------------|----------------|
| Timeserver Synchronization Systems    | 2/2020          | 11/2020            |
| JSON WebService     | 2/20/2020         | 11/2020            |
| Basic UI & Map Controls       |  9/23/2020            |   5/57/2021             |
| DmDATA Wave Monitor API | 8/1/2021 | IN PROGRESS -> Requires Financial Services to maintain API Cost
| PLUM Type Forecasting | TBD | N/A -> Requires Financial Services to maintain API Cost

### Open Source Licenses:

Open source licenses can be found in the open source license folder, respective to their language. (``LICENSE_E`` and ``LICENSE_J``)
