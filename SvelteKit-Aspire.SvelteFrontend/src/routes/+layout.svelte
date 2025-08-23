<script lang="ts">
	import '$lib/assets/main.css';
	import type { Snippet } from 'svelte';

	interface Props {
		children?: Snippet;
	}

	let { children }: Props = $props();
</script>

<div id="app">
	{@render children?.()}
</div>

<style>
	div {
		padding: 2rem;
	}
</style>
