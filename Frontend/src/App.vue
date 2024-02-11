<script setup>
import HelloWorld from './components/HelloWorld.vue'
import VolleyballRotation from './components/VolleyballRotation.vue'
</script>

<template>
  <main>
    <VolleyballRotation />
  </main>
</template>
<style scoped>
.flex-container {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-items: center;
  gap: 10px;
  /* Gap between the squares */
}

.square {
  flex: 0 0 calc(50% - 10px);
  /* Width minus the gap */
  height: 150px;
  background-color: #ccc;
}

@media (max-width: 400px) {
  .square {
    flex: 0 0 calc(100% - 10px);
    /* Full width on small screens */
  }
}</style>
