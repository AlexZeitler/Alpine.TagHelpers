module.exports = {
  content: [
    "**/*.{cshtml,html,js}",
  ],
  safelist: [
    'input-validation-error'
  ],
  theme: {
    extend: {},
    debugScreens: {
      position: ['bottom', 'right'],
    }
  },
  plugins: [
    require("@tailwindcss/forms")({
      strategy: "class",
    }),
    require("tailwindcss-debug-screens"),
  ],
}
