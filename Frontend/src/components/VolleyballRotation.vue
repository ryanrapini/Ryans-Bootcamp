<template>
  <div class="container">
    <div class="row front">
      <div class="square">
        <h2>4 - {{ positionsWithLibero[3] }}</h2>
        {{ players[3] }}
      </div>
      <div class="square">
        <h2>3 - {{ positionsWithLibero[2] }}</h2>
        {{ players[2] }}
      </div>
      <div class="square">
        <h2>2 - {{ positionsWithLibero[1] }}</h2>
        {{ players[1] }}
      </div>
    </div>
    <div class="row back">
      <div class="square">
        <h2>5 - {{ positionsWithLibero[4] }}</h2>
        <template v-if="positionsWithLibero[4] == 'L'">
          {{ libero }}
        </template>
        <template v-else>
          {{ players[4] }}
        </template>
      </div>
      <div class="square">
        <h2>6 - {{ positionsWithLibero[5] }}</h2>
        {{ positionsWithLibero[5] === 'L' ? libero : players[5] }}
      </div>
      <div class="square">
        <h2>1 - {{ positionsWithLibero[0] }}</h2>
        {{ players[0] }}
      </div>
    </div>
    <button @click="rotate()" class="rotate-button"> Rotate! </button>
  </div>
</template>

<script>
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'SquareGrid',
  data() {
    return {
      positions: [
        'S', 'OH', 'MB', 'RS', 'OH', 'MB'
      ],
      players: [
        'Billy', 'Bob', 'Steve', 'Mike', 'Dave', 'Carl'
      ],
      libero: 'Tom'
    }
  },
  computed: {
    positionsWithLibero(){
      var positions = JSON.parse(JSON.stringify(this.positions));
      if (positions[4] == 'MB') {
          positions[4] = 'L'
      }
      if (positions[5] == 'MB') {
          positions[5] = 'L'
      }
      if (positions[0] == 'MB') {
          positions[0] = 'L'
      }
      return positions
    }
  },
  methods: {
    rotate() {
      let firstPosition = this.positions.shift(); // Removes the first item and assigns it to firstPosition
      this.positions.push(firstPosition); // Adds the removed item to the end of the array
      
      let firstPlayer = this.players.shift(); // Removes the first item and assigns it to firstPosition
      this.players.push(firstPlayer); // Adds the removed item to the end of the array
    }


  }
});
</script>

<style scoped>
.container {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  height: 90vh;
  background-color: #333;
  gap: 10px;
  /* Dark grey background */
}

.row {
  display: flex;
  justify-content: center;
  gap: 10px;
}

.square {
  width: 200px;
  height: 150px;
  background-color: #fff;
  /* White squares */
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  text-align: center;
}</style>
