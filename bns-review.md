# Code Review — ninja-name-service (bns)

## 🔴 Критические проблемы

- [ ] `src/App.js` — JSX-комментарии написаны как `// текст` прямо внутри JSX — они рендерятся как видимый текст в браузере. Нужно заменить на `{/* текст */}`
- [ ] `src/App.js` — смарт-контракт адрес `CONTRACT_ADDRESS` захардкожен прямо в коде; при публикации репозитория это нормально, но лучше вынести в `.env` файл
- [ ] `Form1.cs` — C# WinForms файл закоммичен в React-проект. Это посторонний файл из другого проекта, который нужно удалить
- [ ] `LICENSE` — файл пустой

## 🟡 Серьёзные замечания

- [ ] `src/App.js` — `fetchMints` не указан в массиве зависимостей второго `useEffect([currentAccount, network])`, хотя вызывается внутри него — потенциальный stale closure
- [ ] `src/App.js` — `names.indexOf(name)` внутри `Promise.all` map работает неверно при дублирующихся именах и неэффективно; нужно использовать второй параметр callback `(name, index)`
- [ ] `src/index.js` — используется устаревший `ReactDOM.render`, а в `package.json` указан React `^17.0.2`; вместе это нормально, но стоит поднять до React 18 с `createRoot`
- [ ] `public/manifest.json` — содержит дефолтные CRA значения: `"short_name": "React App"`, `"name": "Create React App Sample"` — не обновлены под проект
- [ ] `src/utils/networks.js` — содержит устаревшие тестовые сети Ropsten, Rinkeby, Kovan, которые были отключены в 2022–2023 годах

## 🟢 Замечания по качеству

- [ ] `README.md` — описывает шаблон "Polygon ENS minting template" от buildspace, не заменён на описание реального проекта (Ninja Name Service)
- [ ] `src/App.js` — по всему коду разбросаны `console.log` (подключение кошелька, минтинг, запросы) — нужно убрать перед продакшеном
- [ ] `src/App.js` — `TWITTER_HANDLE` захардкожен как `_buildspace` — нужно заменить на свой хендл
- [ ] `.gitignore` — очень минимальный, игнорирует только `node_modules`; стоит добавить `.env`, `build/`, `coverage/` и прочее
