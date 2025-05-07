import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';
import { viteStaticCopy } from 'vite-plugin-static-copy';

// https://vite.dev/config/
export default defineConfig({
  plugins: [
    react(),
    viteStaticCopy({
      targets: [
        {
          src: 'src/assets/images/**/*', // Копируем все файлы из src/assets/images
          dest: 'assets/images',         // В dist/assets/images
        },
        {
          src: 'src/assets/faces/**/*',  // Копируем все файлы из src/assets/faces
          dest: 'assets/faces',          // В dist/assets/faces
        },
      ],
    }),
  ],
  build: {
    assetsDir: 'assets',
    rollupOptions: {
      input: {
        main: './index.html',
      },
    },
  },
  resolve: {
    alias: {
      '@': '/src',
    },
  },
  server: {
    port: 3000,
  },
});