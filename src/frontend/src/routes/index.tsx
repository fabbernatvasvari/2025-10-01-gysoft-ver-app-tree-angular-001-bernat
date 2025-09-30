import { createFileRoute } from "@tanstack/react-router";

export const Route = createFileRoute("/")({
	component: Index,
});

function Index() {
	return (
		<div className="p-2">
			<h3>Welcome Home! {import.meta.env.VITE_BACKEND_URL}</h3>
		</div>
	);
}
