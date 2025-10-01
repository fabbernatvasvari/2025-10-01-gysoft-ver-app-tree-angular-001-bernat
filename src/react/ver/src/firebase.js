// src/firebase.js

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyAIx1iAaI0TLI4qffd3B1syVvX-6wpv0PM",
  authDomain: "vasvaritanarertekelorendszer.firebaseapp.com",
  projectId: "vasvaritanarertekelorendszer",
  storageBucket: "vasvaritanarertekelorendszer.firebasestorage.app",
  messagingSenderId: "958924585801",
  appId: "1:958924585801:web:1fbe3dda67d3d1a97f7898",
  measurementId: "G-ZF7TMT3RHP"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);
const db = getFirestore(app);

export { analytics, db };