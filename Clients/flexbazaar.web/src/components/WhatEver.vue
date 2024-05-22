<template>
  <div class="greetings">
    <h1>{{currentWhatever}}</h1>
  </div>
</template>

<style scoped>
h1 {
  font-weight: 500;
  font-size: 5.6rem;
}

</style>

<script lang="ts">
  import { defineComponent, ref } from 'vue'
  import WhateverDataService from '@/services/WhateverDataService';
  type ResponseData = typeof import('@/types/ResponseData');

  export default defineComponent({
    name: 'WhatEver',
    data() {
      return {
        currentWhatever: {} as ResponseData
      };
    },
    methods: {
      async getWhatever() {
        try {
          const response = await WhateverDataService.get();
          this.currentWhatever = response.data;
        } catch (error) {
          console.error(error);
        }
      },
    },
    mounted() {
      this.getWhatever();
    },    
  })

</script>

