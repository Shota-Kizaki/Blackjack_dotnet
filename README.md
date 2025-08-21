# Docker Composeを使用したアプリケーションの実行方法

## 基本的な使い方

### 1. アプリケーションのビルドと起動
```bash
docker compose up
```

### 2. バックグラウンドで起動
```bash
docker compose up -d
```

### 3. ログの確認
```bash
docker compose logs -f
```

### 4. 停止
```bash
docker compose down
```

### 5. 強制的にリビルド
```bash
docker compose up --build
```

## カスタマイズ

### 引数を渡してアプリケーションを実行
`docker-compose.yml`の`command`行のコメントアウトを外し、数値を指定してください：
```yaml
command: ["5"]  # 5回カウントして終了
```

### 環境変数の変更
`.env`ファイルを編集して環境変数を変更できます。

## 便利なコマンド

- `docker compose ps` - 実行中のコンテナ確認
- `docker compose exec dotnet-app bash` - コンテナ内にアクセス
- `docker compose restart` - サービスの再起動
- `docker compose pull` - 最新イメージの取得
