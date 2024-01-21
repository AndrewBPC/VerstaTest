const { createProxyMiddleware } = require('http-proxy-middleware');
const { env } = require('process');

const target = `http://localhost:5001`

  

const context =  [
  "/api"
];
const onError = (err, req, resp, target) => {
  console.error(`proxy ${err.message}`);
}
module.exports = function(app) {
  const appProxy = createProxyMiddleware(context, {
    target: target,
    onError: onError,
    secure: false,
    logLevel: 'debug'
  });

  app.use(appProxy);
};
